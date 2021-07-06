[![Build Status](https://github.com/dib0/NHapiTools/actions/workflows/build-status.yml/badge.svg)](https://github.com/dib0/NHapiTools/actions/workflows/build-status.yml)

# NHapiTools
The NHapiTools are tools that will make using NHapi (the open source .Net HL7 implementation) easier. NHapi has a steep learning 
curve and not everything works as easy as it should. NHapiTools aims to improve that without tampering with NHapi itselves.

**Key Benefits**

- Source generation that will generate extension methods on NHapi assemblies. (some generated assemblies are provided)
- Generic extention methods.
- Easy IO tools for reading multiple files, implementing MLLP and filtering Base64 data reducing memory use and increasing speed.
- Tools to generate ACK messages based on any message
- Tools to implement custom (standard) segments (which is not possible with NHapi)
- Default validation rules to be used by the NHapi parser
- Two sets of context implementation to easily add all or configurable validation rules.

## Requirements

NHapiTools currently targets version 4.5 of the .NET Framework

## Getting Started

The easiest way to get started using nHapi is to use the [NuGet package 'NHapiTools'](https://www.nuget.org/packages/NHapiTools/):

Using the package manager console withing visual studio, simply run the following command:

```
PM > Install-Package NHapiTools
```

## Introduction

On my blog I get a lot of questions on how to set up a complete .Net system for HL7 message integration. In other words: all over the world developers create integration components from scratch to add HL7 integration to their applications. After working for a while with NHapi, the most complete and free component to support HL7 with .Net, I started to miss functionality. To make my life easier (and hopefully the life of other developers, I created the NHapiTools. 
In this document the functionality that NHapiTools adds to the NHapi component will be explained.

The sources and releases of NHapiTools can be found on Github:
https://github.com/dib0/NHapiTools

Also check out HL7Fuse:
https://github.com/dib0/HL7Fuse

And, of course, The NHapi Beginner’s Guide:
http://www.smashwords.com/books/view/344824

## The Structure of NHapiTools

For the most important part NHapiTools is a set of extension methods that extend NHapi. NHapi uses a code generator to generate the HL7 message structure into classes and then assemblies. NHapiTools uses the same mechanism to generate classes with extension methods based on the NHapi assemblies. The generated classes are provided within the source, so you don’t have to do this (of course, if you want to, you can).

The extension methods make it far easier to enumerate through the messages. For example: they will allow you to use the “foreach” statement, which the basic NHapi structure doesn’t allow.

Besides the extension methods and richer validations NHapiTools provide tools for commonly used patterns within HL7 and HL7 integration. For example support for MLLP, a TCP/IP MLLP client, a method of generation ACK messages based on any method and alternative streams that filter out attached Base64 encoded documents that makes parsing large message easier and (much) faster.

## Extension Methods

NHapi, probably the part you'll never use, is actually a code generator. Based on the HL7 structure database, that can be obtained through the local HL7 organization, it will generate the classes for the data types, segments and message structures. It also forces the Hl7 standard within these classes.

Annoying about in these NHapi HL7 structures are the way repeating segments or fields are handled. NHapi generates a method to get the number of repetitions with a name like Get{property name}RepetitionsUsed(). With the methods Get{property name}(int repetition) you can get to a specific repeating field. Note that the last one can also be used to add a new repetition if you are creating a new message. The annoying part is that you always have to write the same for-loop to go through the data. I would rather be using the foreach statement, which will give you more readable and maintainable code.

The extention methods in NHapiTools do just that. NHapiTools contains a code generator that generates the extention methods based on the NHapi assemblies. NHapiTools also contain the compiled version, so you don't have to run the generator. That means by using the namespace of the extention assemblies you can use the using statements. So you can turn this:
```
for (int i=0; i< oMessage.PATIENT_RESULTRepetitionsUsed; i++)
{
    PID pid = oMessage.GetPATIENT_RESULT(i).PATIENT.PID;
    for (int y=0; y < pid.AlternatePatientIDPIDRepetitionsUsed; y++)
    {
        CX alterateId = pid.GetAlternatePatientIDPID(y);
        // do something with the alternate ID
    }
}
```

Into this:
```
foreach (ORU_R01_PATIENT_RESULT patient in oMessage.GetAllPATIENT_RESULTRecords())
{
    PID pid = patient.PATIENT.PID;
    
    foreach (CX alternateId in pid.GetAlternatePatientIDPIDRecords())
    {
        // do something with the alternate ID
    }
}
```

Besides methods to easily use the foreach statement NHapiTools also provide a clearer way to add repeating fields. Instead of the NHapi method to “get” the next (non existing) enumeration NHapiTools provides a simple add extention methods to perform this operation.

## Validation

The validation of HL7 messages is embedded in the classes of NHapi. That means that the messages are validated if they are conform the HL7 specification standard. The NHapi parser utilizes a context for parsing. If you choose to use your own context you can influence the parsing. For example, by adding validation rules.

The way these validation rules are implemented and the context you have to create aren't really complicated, but since the rules are version specific and you might have to develop complex rules or many rules, maintaining them can be a hassle. NHapiTools provides two different contexts and a set of generic validation rules.

### Automated Context

The automated context allows you to develop you own set of validation rules. You will have to implement the ISpecificEncodingRule, ISpecificMessageRule or the ISpecificPrimitiveRule interface. The automated context will search through every type within a namespace and applies all the rules it can find to the parser. This will save you a lot of time maintaining and building the context. It needs a namespace:
```
<appSettings>
	<add key="NHapiRulesNamespace" value="TestApp, version=1.0.0.0"/>
</appSettings>
```

To use the automated context you will need to add the following lines of code:
```
PipeParser parser = new PipeParser();
AutomatedContext context = new AutomatedContext(parser.ValidationContext);
parser.ValidationContext = context;
```

### Configurable Context

The configurable context also allows you to implement your own validation rules, by implementing the same interfaces. The difference with the automated context is that you can configure which rules must be applied. This will give you far more control over the behavior of you application in different circumstances. To configure rules do the following:
```
<configSections>
	<sectionGroup name="hl7ValidationRulesGroup">
		<section name="hl7ValidationRules" type="NHapiTools.Base.Configuration.ValidationSection, NHapiTools.Base, version=1.0.0.0"/>
	</sectionGroup>
</configSections>

<hl7ValidationRulesGroup>
	<hl7ValidationRules>
		<EncodingRules>
			<add Name="EncodingRule1" Assembly="TestApp" Type="TestApp.CustomRules.EncodingRule1"/>
		</EncodingRules>
		<MessageRules>
			<add Name="MessageRule" Assembly="TestApp" Type="TestApp.CustomRules.MessageRule"/>
			<add Name="MandatorySegments" Assembly="NHapiTools.Base" Type=" NHapiTools.Base.Validation.Rule.MessageSegmentMandatoryRule"/>
			<add Name="MessageRegExField" Assembly="NHapiTools.Base" Type=" NHapiTools.Base.Validation.Rule.MessageRegExRule"/>
			<add Name="MessageFieldIntOnly" Assembly="NHapiTools.Base" Type=" NHapiTools.Base.Validation.Rule.MessageFieldIntOnlyRule"/>
			<add Name="MessageFieldMandatory" Assembly="NHapiTools.Base" Type=" NHapiTools.Base.Validation.Rule.MessageFieldMandatoryRule"/>
		</MessageRules>
	</hl7ValidationRules>
</hl7ValidationRulesGroup>
```

To use the configurable context with the parser you will need to add the following code:
```
PipeParser parser = new PipeParser();
ConfigurableContext context = new ConfigurableContext(parser.ValidationContext);
parser.ValidationContext = context;
```

### Standard Validation Rules

Developing you own set of validation rules can be a hassle on it's own. It would be better if there were a set of configurable rules the will cover the basics (and hopefully all that you will need). NHapiTools provides a set of generic rules that you can use by configuration. These work well with the configurable context. 

The following rules are provided:
<table>
    <tr>
        <td>MessageFieldIntOnlyRule</td>
        <td>Checks the content of a specific field in the message and allows only integer values.</td>
    </tr>
    <tr>
        <td>MessageFieldMandatoryRule</td>
        <td>Check if a specific field in the message exists and if the field isn't empty.</td>
    </tr>
    <tr>
        <td>MessageRegExRule</td>
        <td>Checks the content of a specific field against a regular expression.</td>
    </tr>
    <tr>
        <td>MessageSegmentMandatoryRule</td>
        <td>Checks if a given segment exists. Which is otherwise quite hard to check.</td>
    </tr>
</table>

The various rules require configuration. All rules require a unique name, Hl7 version they apply to, the message type they apply to and the trigger event. All of these option, except for the first one, allow the '\*' (multiple unknown characters) and '?' (a single unknown character) as wild cards. If a rule needs a field indicator, this always follows the standard HL7 notation (e.g. “PID-2-1”). The configuration looks like this:
```
<configSections>
	<sectionGroup name="SpecificRulesGroup">
		<section name="SpecificRules" type="NHapiTools.Base.Configuration.MessageRulesSection, NHapiTools.Base, version=1.0.0.0"/>
	</sectionGroup>
</configSections>
```

And:
```
<SpecificRulesGroup>
	<SpecificRules>
		<SegmentMandatoryRule>
			<add Name="MandatoryPIDOn2.1_ADT_A01" Version="2.4" MessageType="ADT" TriggerEvent="A01" MadatorySegment="PID"/>
			<add Name="MandatoryPIDOn*" Version="*" MessageType="*" TriggerEvent="*" MadatorySegment="PID"/>
		</SegmentMandatoryRule>
		<MessageRegExRule>
			<add Name="RegExOn2.1_ADT_A01" Version="2.4" MessageType="ADT" TriggerEvent="A01" FieldIndicator="MSH-9-1" RegEx=""/>
			<add Name="RegExOnMSH-10-1" Version="*" MessageType="*" TriggerEvent="*" FieldIndicator="MSH-10-1" RegEx="^\d+$" AllowNull="false"/>
		</MessageRegExRule>
		<MessageFieldIntOnlyRule>
			<add Name="IntOnlyOnMSH-3-1" Version="*" MessageType="ADT" TriggerEvent="*" FieldIndicator="PID-3-1" AllowNull="true"/>
		</MessageFieldIntOnlyRule>
		<MessageFieldMandatoryRule>
			<add Name="MandatoryFieldADT_MSH-2-1" Version="*" MessageType="ADT" TriggerEvent="*" FieldIndicator="PID-2-1"/>
			<add Name="MandatoryFieldDFT_MSH-2-1" Version="*" MessageType="DFT" TriggerEvent="*" FieldIndicator="PID-2-1"/>
		</MessageFieldMandatoryRule>
	</SpecificRules>
</SpecificRulesGroup>
```

## Utils

There is quite a diversity of tools within the NHapiTools. In this chapter IO tools, network tools and HL7 tooling.

### IO

The IO namespace has two stream classes and two enumeration classes. The `HL7FilterBase64AttachmentsStream` allows you to read a HL7 message, but separate Base64 content. In some cases, for example lab results that contain PDF files, the HL7 message become quite large. These large messages take a lot of time to parse with NHapi. Using this stream will insert a dummy text (thus increasing the parsing speed) and allows you to read the attachments after parsing the message.

The other stream is the `MultipleFilesStream`. This class is not directly HL7 related, but just allows you to read the content of a complete directory as one stream, so you don’t have to care about which file you are reading or not. Using the OnFileCompleted event (that fires once a file has been completely read) you can perform specific file actions, like archiving or deleting the file.

The `HL7InputStreamMessageEnumerator` is a port of the Hl7InputStreamMessageIterator class from the Hapi project. This class wasn’t migrated to the NHapi source code, but is can be useful. It allows you to enumerate HL7 messages from a stream (preferably a file stream) and parses the message to an IMessage object. So you don’t have to care about when a HL7 message begins or ends.

The `HL7InputStreamMessageStringEnumerator` does the same thing, but enumerates the message as a string instead of parsing it to an IMessage object.

### Net

The `SimpleMLLPClient` is a TCP/IP client that allows you to connect to a HL7 server and send a HL7 message using the MLLP protocol. It will return the response as an IMessage object. It uses the MLLP class to perform MLLP actions.

### HL7

There are some other interesting tools for handeling HL7 messages. The `Ack` class is a simple ACK message generator, that generates any possible ACK message based on a IMessage object.

#### GenericMessageWrapper

A slightly more complicated tool is the `GenericMessageWrapper`. As you know you can add custom segments to HL7 messages. The parser will automatically recognize these and load the custom segments. The harder part is that you need to override the message structure as well. If you need to override standard segments, for example the PID segment, the only way is to add a custom implementation of the complete message. But if you want to use this custom PID segment on all messages, you’re about to recompile the complete NHapi structure.<br />
On the other hand, making custom changes in standard components should always be prevented!

Using the `GenericMessageWrapper` you can parse any message to this implementation of an `AbstractMessage`. This wrapper allows you to cast the message to the right class structure, while maintaining the possibility to easily get to custom implementations of segments etc.<br />
So this wrapper allows you to keep all the standard components standard, but adds enough flexibility to implement your own custom implementations.
To use this `GenericMessageWrapper`:
```
EnhancedModelClassFactory emch = new EnhancedModelClassFactory();
PipeParser parser = new PipeParser(emch);
emch.ValidationContext = parser.ValidationContext;

IMessage im = parser.Parse(txtMessage);
GenericMessageWrapper gcw = im as GenericMessageWrapper;
if (gcw != null)
    IMessage originalMessage = gcw.Unwrap();
```
