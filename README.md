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

##Requirements

NHapiTools currently targets version 4.5 of the .NET Framework

##Getting Started

The easiest way to get started using nHapi is to use the [NuGet package 'NHapiTools'](https://www.nuget.org/packages/NHapiTools/):

Using the package manager console withing visual studio, simply run the following command:

```
PM > Install-Package NHapiTools
```