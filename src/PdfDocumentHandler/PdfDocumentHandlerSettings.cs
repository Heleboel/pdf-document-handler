using System.Configuration;
using PdfDocumentHandler.Models;


namespace PdfDocumentHandler;

[Serializable]
internal sealed class PdfDocumentHandlerSettings : ApplicationSettingsBase
{
    private const string KeyUpgradeRequired = "UpgradeRequired";
    private const string KeyFormLocation    = "FormLocation";
    private const string KeyFormState       = "FormState";


    [UserScopedSetting]
    [DefaultSettingValue("true")]
    public bool UpgradeRequired
    {
        get { return (bool)this[KeyUpgradeRequired]; }
        set { this[KeyUpgradeRequired] = value; }
    }


    [UserScopedSetting]
    [DefaultSettingValue("20, 20")]
    public Point FormLocation
    {
        get { return (Point)this[KeyFormLocation]; }
        set { this[KeyFormLocation] = value; }
    }


    [UserScopedSetting]
    [DefaultSettingValue("0")]
    public FormWindowState FormState
    {
        get { return (FormWindowState) this[KeyFormState]; }
        set { this[KeyFormState] = value; }
    }


    [UserScopedSetting]
    [DefaultSettingValue("1225, 600")]
    public Size FormSize
    {
        get { return (Size)this["FormSize"]; }
        set { this["FormSize"] = value; }
    }


    [UserScopedSetting]
    [DefaultSettingValue("760")]
    public int SplitterDistance
    {
        get { return (int)this["SplitterDistance"]; }
        set { this["SplitterDistance"] = value; }
    }


    [UserScopedSetting]
    public List<string> SourceFolders
    {
        get { return (List<string>) this["SourceFolders"]; }
        set { this["SourceFolders"] = value; }
    }


    [UserScopedSetting]
    public List<Destination> Destinations
    {
        get { return (List<Destination>)this["Destinations"]; }
        set { this["Destinations"] = value; }
    }
}
