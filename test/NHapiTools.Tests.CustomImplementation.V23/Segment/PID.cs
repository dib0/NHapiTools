using System;
using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V23.Datatype;

namespace NHapiTools.Tests.CustomImplementation.V23.Segment
{
  /// <summary>
  /// Represents an HL7 PID message segment. (Custom implementation with a repeatng Alternate Patient ID)
  ///              This segment has the following fields:<ol><li>PID-1: Set ID - Patient ID (SI)</li><li>PID-2: Patient ID (External ID) (CX)</li><li>PID-3: Patient ID (Internal ID) (CX)</li><li>PID-4: Alternate Patient ID (CX)</li><li>PID-5: Patient Name (XPN)</li><li>PID-6: Mother's Maiden Name (XPN)</li><li>PID-7: Date of Birth (TS)</li><li>PID-8: Sex (IS)</li><li>PID-9: Patient Alias (XPN)</li><li>PID-10: Race (IS)</li><li>PID-11: Patient Address (XAD)</li><li>PID-12: County Code (IS)</li><li>PID-13: Phone Number - Home (TN)</li><li>PID-14: Phone Number - Business (TN)</li><li>PID-15: Primary Language (CE)</li><li>PID-16: Marital Status (IS)</li><li>PID-17: Religion (IS)</li><li>PID-18: Patient Account Number (CX)</li><li>PID-19: SSN Number - Patient (ST)</li><li>PID-20: Driver's License Number (DLN)</li><li>PID-21: Mother's Identifier (CX)</li><li>PID-22: Ethnic Group (IS)</li><li>PID-23: Birth Place (ST)</li><li>PID-24: Multiple Birth Indicator (ID)</li><li>PID-25: Birth Order (NM)</li><li>PID-26: Citizenship (IS)</li><li>PID-27: Veterans Military Status (CE)</li><li>PID-28: Nationality Code (CE)</li><li>PID-29: Patient Death Date and Time (TS)</li><li>PID-30: Patient Death Indicator (ID)</li></ol>
  ///              The get...() methods return data from individual fields.  These methods
  ///              do not throw exceptions and may therefore have to handle exceptions internally.
  ///              If an exception is handled internally, it is logged and null is returned.
  ///              This is not expected to happen - if it does happen this indicates not so much
  ///              an exceptional circumstance as a bug in the code for this class.
  /// 
  /// </summary>
  [Serializable]
  public class PID : AbstractSegment
  {
    /// <summary>
    /// Returns Set ID - Patient ID(PID-1).
    /// 
    /// </summary>
    public SI SetIDPatientID
    {
      get
      {
        SI si;
        try
        {
          si = (SI) this.GetField(1, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return si;
      }
    }

    /// <summary>
    /// Returns Patient ID (External ID)(PID-2).
    /// 
    /// </summary>
    public CX PatientIDExternalID
    {
      get
      {
        CX cx;
        try
        {
          cx = (CX) this.GetField(2, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return cx;
      }
    }

    /// <summary>
    /// Returns the total repetitions of Patient ID (Internal ID) (PID-3).
    /// 
    /// </summary>
    public int PatientIDInternalIDRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(3);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns a single repetition of Alternate Patient ID (PID-4).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CX GetAlternatePatientID(int rep)
    {
        CX cx;
        try
        {
            cx = (CX)this.GetField(4, rep);
        }
        catch (Exception ex)
        {
            HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected problem obtaining field value.  This is a bug.", ex);
            throw new Exception("An unexpected error ocurred", ex);
        }
        return cx;
    }

    /// <summary>
    /// Returns the total repetitions of Alternate Patient ID (PID-4).
    /// 
    /// </summary>
    public int AlternatePatientIDRepetitionsUsed
    {
        get
        {
            try
            {
                return this.GetTotalFieldRepetitionsUsed(4);
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected problem obtaining field value.  This is a bug.", (Exception)ex);
                throw new Exception("An unexpected error ocurred", (Exception)ex);
            }
            catch (Exception ex)
            {
                HapiLogFactory.GetHapiLog(this.GetType()).Error((object)"Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error ocurred", ex);
            }
        }
    }

    /// <summary>
    /// Returns Patient Name(PID-5).
    /// 
    /// </summary>
    public XPN PatientName
    {
      get
      {
        XPN xpn;
        try
        {
          xpn = (XPN) this.GetField(5, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return xpn;
      }
    }

    /// <summary>
    /// Returns Mother's Maiden Name(PID-6).
    /// 
    /// </summary>
    public XPN MotherSMaidenName
    {
      get
      {
        XPN xpn;
        try
        {
          xpn = (XPN) this.GetField(6, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return xpn;
      }
    }

    /// <summary>
    /// Returns Date of Birth(PID-7).
    /// 
    /// </summary>
    public TS DateOfBirth
    {
      get
      {
        TS ts;
        try
        {
          ts = (TS) this.GetField(7, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return ts;
      }
    }

    /// <summary>
    /// Returns Sex(PID-8).
    /// 
    /// </summary>
    public IS Sex
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(8, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns the total repetitions of Patient Alias (PID-9).
    /// 
    /// </summary>
    public int PatientAliasRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(9);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns Race(PID-10).
    /// 
    /// </summary>
    public IS Race
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(10, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns the total repetitions of Patient Address (PID-11).
    /// 
    /// </summary>
    public int PatientAddressRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(11);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns County Code(PID-12).
    /// 
    /// </summary>
    public IS CountyCode
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(12, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns the total repetitions of Phone Number - Home (PID-13).
    /// 
    /// </summary>
    public int PhoneNumberHomeRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(13);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns the total repetitions of Phone Number - Business (PID-14).
    /// 
    /// </summary>
    public int PhoneNumberBusinessRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(14);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns Primary Language(PID-15).
    /// 
    /// </summary>
    public CE PrimaryLanguage
    {
      get
      {
        CE ce;
        try
        {
          ce = (CE) this.GetField(15, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return ce;
      }
    }

    /// <summary>
    /// Returns the total repetitions of Marital Status (PID-16).
    /// 
    /// </summary>
    public int MaritalStatusRepetitionsUsed
    {
      get
      {
        try
        {
          return this.GetTotalFieldRepetitionsUsed(16);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
      }
    }

    /// <summary>
    /// Returns Religion(PID-17).
    /// 
    /// </summary>
    public IS Religion
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(17, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns Patient Account Number(PID-18).
    /// 
    /// </summary>
    public CX PatientAccountNumber
    {
      get
      {
        CX cx;
        try
        {
          cx = (CX) this.GetField(18, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return cx;
      }
    }

    /// <summary>
    /// Returns SSN Number - Patient(PID-19).
    /// 
    /// </summary>
    public ST SSNNumberPatient
    {
      get
      {
        ST st;
        try
        {
          st = (ST) this.GetField(19, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return st;
      }
    }

    /// <summary>
    /// Returns Driver's License Number(PID-20).
    /// 
    /// </summary>
    public DLN DriverSLicenseNumber
    {
      get
      {
        DLN dln;
        try
        {
          dln = (DLN) this.GetField(20, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return dln;
      }
    }

    /// <summary>
    /// Returns Mother's Identifier(PID-21).
    /// 
    /// </summary>
    public CX MotherSIdentifier
    {
      get
      {
        CX cx;
        try
        {
          cx = (CX) this.GetField(21, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return cx;
      }
    }

    /// <summary>
    /// Returns Ethnic Group(PID-22).
    /// 
    /// </summary>
    public IS EthnicGroup
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(22, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns Birth Place(PID-23).
    /// 
    /// </summary>
    public ST BirthPlace
    {
      get
      {
        ST st;
        try
        {
          st = (ST) this.GetField(23, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return st;
      }
    }

    /// <summary>
    /// Returns Multiple Birth Indicator(PID-24).
    /// 
    /// </summary>
    public ID MultipleBirthIndicator
    {
      get
      {
        ID id;
        try
        {
          id = (ID) this.GetField(24, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return id;
      }
    }

    /// <summary>
    /// Returns Birth Order(PID-25).
    /// 
    /// </summary>
    public NM BirthOrder
    {
      get
      {
        NM nm;
        try
        {
          nm = (NM) this.GetField(25, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return nm;
      }
    }

    /// <summary>
    /// Returns Citizenship(PID-26).
    /// 
    /// </summary>
    public IS Citizenship
    {
      get
      {
        IS @is;
        try
        {
          @is = (IS) this.GetField(26, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return @is;
      }
    }

    /// <summary>
    /// Returns Veterans Military Status(PID-27).
    /// 
    /// </summary>
    public CE VeteransMilitaryStatus
    {
      get
      {
        CE ce;
        try
        {
          ce = (CE) this.GetField(27, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return ce;
      }
    }

    /// <summary>
    /// Returns Nationality Code(PID-28).
    /// 
    /// </summary>
    public CE NationalityCode
    {
      get
      {
        CE ce;
        try
        {
          ce = (CE) this.GetField(28, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return ce;
      }
    }

    /// <summary>
    /// Returns Patient Death Date and Time(PID-29).
    /// 
    /// </summary>
    public TS PatientDeathDateAndTime
    {
      get
      {
        TS ts;
        try
        {
          ts = (TS) this.GetField(29, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return ts;
      }
    }

    /// <summary>
    /// Returns Patient Death Indicator(PID-30).
    /// 
    /// </summary>
    public ID PatientDeathIndicator
    {
      get
      {
        ID id;
        try
        {
          id = (ID) this.GetField(30, 0);
        }
        catch (HL7Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
          throw new Exception("An unexpected error ocurred", (Exception) ex);
        }
        catch (Exception ex)
        {
          HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
          throw new Exception("An unexpected error ocurred", ex);
        }
        return id;
      }
    }

    /// Creates a PID (Patient Identification) segment object that belongs to the given
    ///             message.
    public PID(IGroup parent, IModelClassFactory factory)
      : base(parent, factory)
    {
      IMessage message = this.Message;
      try
      {
        this.add(typeof (SI), 0 != 0, 1, 4, new object[1]
        {
          (object) message
        }, "Set ID - Patient ID");
        this.add(typeof (CX), 0 != 0, 1, 16, new object[1]
        {
          (object) message
        }, "Patient ID (External ID)");
        this.add(typeof (CX), 1 != 0, 0, 20, new object[1]
        {
          (object) message
        }, "Patient ID (Internal ID)");
        this.add(typeof (CX), 0 != 0, 10, 12, new object[1]
        {
          (object) message
        }, "Alternate Patient ID");
        this.add(typeof (XPN), 1 != 0, 1, 48, new object[1]
        {
          (object) message
        }, "Patient Name");
        this.add(typeof (XPN), 0 != 0, 1, 48, new object[1]
        {
          (object) message
        }, "Mother's Maiden Name");
        this.add(typeof (TS), 0 != 0, 1, 26, new object[1]
        {
          (object) message
        }, "Date of Birth");
        this.add(typeof (IS), 0 != 0, 1, 1, new object[2]
        {
          (object) message,
          (object) 1
        }, "Sex");
        this.add(typeof (XPN), 0 != 0, 0, 48, new object[1]
        {
          (object) message
        }, "Patient Alias");
        this.add(typeof (IS), 0 != 0, 1, 1, new object[2]
        {
          (object) message,
          (object) 5
        }, "Race");
        this.add(typeof (XAD), 0 != 0, 0, 106, new object[1]
        {
          (object) message
        }, "Patient Address");
        this.add(typeof (IS), 0 != 0, 1, 4, new object[2]
        {
          (object) message,
          (object) 0
        }, "County Code");
        this.add(typeof (TN), 0 != 0, 0, 40, new object[1]
        {
          (object) message
        }, "Phone Number - Home");
        this.add(typeof (TN), 0 != 0, 0, 40, new object[1]
        {
          (object) message
        }, "Phone Number - Business");
        this.add(typeof (CE), 0 != 0, 1, 60, new object[1]
        {
          (object) message
        }, "Primary Language");
        this.add(typeof (IS), 0 != 0, 0, 1, new object[2]
        {
          (object) message,
          (object) 2
        }, "Marital Status");
        this.add(typeof (IS), 0 != 0, 1, 3, new object[2]
        {
          (object) message,
          (object) 6
        }, "Religion");
        this.add(typeof (CX), 0 != 0, 1, 20, new object[1]
        {
          (object) message
        }, "Patient Account Number");
        this.add(typeof (ST), 0 != 0, 1, 16, new object[1]
        {
          (object) message
        }, "SSN Number - Patient");
        this.add(typeof (DLN), 0 != 0, 1, 25, new object[1]
        {
          (object) message
        }, "Driver's License Number");
        this.add(typeof (CX), 0 != 0, 1, 20, new object[1]
        {
          (object) message
        }, "Mother's Identifier");
        this.add(typeof (IS), 0 != 0, 1, 1, new object[2]
        {
          (object) message,
          (object) 189
        }, "Ethnic Group");
        this.add(typeof (ST), 0 != 0, 1, 60, new object[1]
        {
          (object) message
        }, "Birth Place");
        this.add(typeof (ID), 0 != 0, 1, 2, new object[2]
        {
          (object) message,
          (object) 136
        }, "Multiple Birth Indicator");
        this.add(typeof (NM), 0 != 0, 1, 2, new object[1]
        {
          (object) message
        }, "Birth Order");
        this.add(typeof (IS), 0 != 0, 1, 4, new object[2]
        {
          (object) message,
          (object) 171
        }, "Citizenship");
        this.add(typeof (CE), 0 != 0, 1, 60, new object[1]
        {
          (object) message
        }, "Veterans Military Status");
        this.add(typeof (CE), 0 != 0, 1, 80, new object[1]
        {
          (object) message
        }, "Nationality Code");
        this.add(typeof (TS), 0 != 0, 1, 26, new object[1]
        {
          (object) message
        }, "Patient Death Date and Time");
        this.add(typeof (ID), 0 != 0, 1, 1, new object[2]
        {
          (object) message,
          (object) 136
        }, "Patient Death Indicator");
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) ("Can't instantiate " + this.GetType().Name), (Exception) ex);
      }
    }

    /// <summary>
    /// Returns a single repetition of Patient ID (Internal ID)(PID-3).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CX GetPatientIDInternalID(int rep)
    {
      CX cx;
      try
      {
        cx = (CX) this.GetField(3, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return cx;
    }

    /// <summary>
    /// Returns all repetitions of Patient ID (Internal ID) (PID-3).
    /// 
    /// </summary>
    public CX[] GetPatientIDInternalID()
    {
      CX[] cxArray;
      try
      {
        IType[] field = this.GetField(3);
        cxArray = new CX[field.Length];
        for (int index = 0; index < cxArray.Length; ++index)
          cxArray[index] = (CX) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return cxArray;
    }

    /// <summary>
    /// Returns a single repetition of Patient Alias(PID-9).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public XPN GetPatientAlias(int rep)
    {
      XPN xpn;
      try
      {
        xpn = (XPN) this.GetField(9, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return xpn;
    }

    /// <summary>
    /// Returns all repetitions of Patient Alias (PID-9).
    /// 
    /// </summary>
    public XPN[] GetPatientAlias()
    {
      XPN[] xpnArray;
      try
      {
        IType[] field = this.GetField(9);
        xpnArray = new XPN[field.Length];
        for (int index = 0; index < xpnArray.Length; ++index)
          xpnArray[index] = (XPN) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return xpnArray;
    }

    /// <summary>
    /// Returns a single repetition of Patient Address(PID-11).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public XAD GetPatientAddress(int rep)
    {
      XAD xad;
      try
      {
        xad = (XAD) this.GetField(11, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return xad;
    }

    /// <summary>
    /// Returns all repetitions of Patient Address (PID-11).
    /// 
    /// </summary>
    public XAD[] GetPatientAddress()
    {
      XAD[] xadArray;
      try
      {
        IType[] field = this.GetField(11);
        xadArray = new XAD[field.Length];
        for (int index = 0; index < xadArray.Length; ++index)
          xadArray[index] = (XAD) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return xadArray;
    }

    /// <summary>
    /// Returns a single repetition of Phone Number - Home(PID-13).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetPhoneNumberHome(int rep)
    {
      TN tn;
      try
      {
        tn = (TN) this.GetField(13, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return tn;
    }

    /// <summary>
    /// Returns all repetitions of Phone Number - Home (PID-13).
    /// 
    /// </summary>
    public TN[] GetPhoneNumberHome()
    {
      TN[] tnArray;
      try
      {
        IType[] field = this.GetField(13);
        tnArray = new TN[field.Length];
        for (int index = 0; index < tnArray.Length; ++index)
          tnArray[index] = (TN) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return tnArray;
    }

    /// <summary>
    /// Returns a single repetition of Phone Number - Business(PID-14).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetPhoneNumberBusiness(int rep)
    {
      TN tn;
      try
      {
        tn = (TN) this.GetField(14, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return tn;
    }

    /// <summary>
    /// Returns all repetitions of Phone Number - Business (PID-14).
    /// 
    /// </summary>
    public TN[] GetPhoneNumberBusiness()
    {
      TN[] tnArray;
      try
      {
        IType[] field = this.GetField(14);
        tnArray = new TN[field.Length];
        for (int index = 0; index < tnArray.Length; ++index)
          tnArray[index] = (TN) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return tnArray;
    }

    /// <summary>
    /// Returns a single repetition of Marital Status(PID-16).
    ///              throws HL7Exception if the repetition number is invalid.
    ///              <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public IS GetMaritalStatus(int rep)
    {
      IS @is;
      try
      {
        @is = (IS) this.GetField(16, rep);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return @is;
    }

    /// <summary>
    /// Returns all repetitions of Marital Status (PID-16).
    /// 
    /// </summary>
    public IS[] GetMaritalStatus()
    {
      IS[] isArray;
      try
      {
        IType[] field = this.GetField(16);
        isArray = new IS[field.Length];
        for (int index = 0; index < isArray.Length; ++index)
          isArray[index] = (IS) field[index];
      }
      catch (HL7Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", (Exception) ex);
        throw new Exception("An unexpected error ocurred", (Exception) ex);
      }
      catch (Exception ex)
      {
        HapiLogFactory.GetHapiLog(this.GetType()).Error((object) "Unexpected problem obtaining field value.  This is a bug.", ex);
        throw new Exception("An unexpected error ocurred", ex);
      }
      return isArray;
    }
  }
}
