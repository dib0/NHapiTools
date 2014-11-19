using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NHapi.Base;
using NHapi.Base.Model.Configuration;

namespace NHapiTools.Base.Parser
{
  internal class PackageManager
  {
    private List<Hl7Package> _packages = new List<Hl7Package>();
    private static readonly PackageManager _instance = new PackageManager();

    public static PackageManager Instance
    {
      get
      {
        return PackageManager._instance;
      }
    }

    static PackageManager()
    {
    }

    private PackageManager()
    {
      this.LoadBaseVersions();
      this.LoadAdditionalVersions();
    }

    public IList<Hl7Package> GetAllPackages()
    {
      return (IList<Hl7Package>) this._packages;
    }

    private void LoadBaseVersions()
    {
      string[] strArray = new string[6]
      {
        "2.2",
        "2.3",
        "2.3.1",
        "2.4",
        "2.5",
        "2.5.1"
      };
      foreach (string str in strArray)
        this._packages.Add(new Hl7Package(PackageManager.GetVersionPackageName(str), str));
    }

    private void LoadAdditionalVersions()
    {
      HL7PackageConfigurationSection configurationSection = ConfigurationManager.GetSection("Hl7PackageCollection") as HL7PackageConfigurationSection;
      if (configurationSection == null)
        return;
      foreach (HL7PackageElement hl7PackageElement in (ConfigurationElementCollection) configurationSection.Packages)
        this._packages.Insert(0, new Hl7Package(hl7PackageElement.Name, hl7PackageElement.Version));
    }

    public bool IsValidVersion(string version)
    {
      version = version.ToUpper().Trim();
      foreach (Hl7Package hl7Package in this._packages)
      {
        if (hl7Package.Version.ToUpper().Trim().Equals(version))
          return true;
      }
      return false;
    }

    /// <summary>
    /// Returns the path to the base package for model elements of the given version
    ///             - e.g. "NHapi.Model.VXXX".
    ///             This package should have the packages datatype, segment, group, and message
    ///             under it. The path ends in with a slash.
    /// 
    /// </summary>
    public static string GetVersionPackagePath(string ver)
    {
      StringBuilder stringBuilder = new StringBuilder("NHapi.Model.V");
      char[] destinationArray = new char[ver.Length];
      SupportClass.GetCharsFromString(ver, 0, ver.Length, destinationArray, 0);
      for (int index = 0; index < destinationArray.Length; ++index)
      {
        if ((int) destinationArray[index] != 46)
          stringBuilder.Append(destinationArray[index]);
      }
      stringBuilder.Append("/");
      return ((object) stringBuilder).ToString();
    }

    /// <summary>
    /// Returns the package name for model elements of the given version - e.g.
    ///             "NHapi.Base.Model.v24.".  This method
    ///             is identical to
    /// <code>
    /// getVersionPackagePath(...)
    /// </code>
    ///  except that path
    ///             separators are replaced with dots.
    /// 
    /// </summary>
    public static string GetVersionPackageName(string ver)
    {
      return PackageManager.GetVersionPackagePath(ver).Replace('/', '.').Replace('\\', '.');
    }
  }
}