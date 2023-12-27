using System.Configuration;
using PdfDocumentHandler.Models;


namespace PdfDocumentHandler;

[Serializable]
internal sealed class PdfDocumentHandlerSettings : ApplicationSettingsBase
{
    private const string KeyUpgradeRequired = nameof(UpgradeRequired);
    private const string KeyFormLocation    = nameof(FormLocation);
    private const string KeyFormState       = nameof(FormState);


    [UserScopedSetting]
    [DefaultSettingValue("true")]
    public bool UpgradeRequired
    {
        get => (bool)this[KeyUpgradeRequired];
        set => this[KeyUpgradeRequired] = value;
    }


    [UserScopedSetting]
    [DefaultSettingValue("20, 20")]
    public Point FormLocation
    {
        get => (Point)this[KeyFormLocation];
        set => this[KeyFormLocation] = value;
    }


    [UserScopedSetting]
    [DefaultSettingValue("0")]
    public FormWindowState FormState
    {
        get => (FormWindowState)this[KeyFormState];
        set => this[KeyFormState] = value;
    }


    [UserScopedSetting]
    [DefaultSettingValue("1225, 600")]
    public Size FormSize
    {
        get => (Size)this[nameof(FormSize)];
        set => this[nameof(FormSize)] = value;
    }


    [UserScopedSetting]
    [DefaultSettingValue("760")]
    public int SplitterDistance
    {
        get => (int)this[nameof(SplitterDistance)];
        set => this[nameof(SplitterDistance)] = value;
    }


    [UserScopedSetting]
    public List<string> SourceFolders
    {
        get => (List<string>)this[nameof(SourceFolders)];
        set => this[nameof(SourceFolders)] = value;
    }


    [UserScopedSetting]
    public List<Destination> Destinations
    {
        get => (List<Destination>)this[nameof(Destinations)] ?? new List<Destination>();
        set => this[nameof(Destinations)] = value;
    }
}
