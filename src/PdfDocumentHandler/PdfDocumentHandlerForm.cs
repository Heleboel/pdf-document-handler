using System.ComponentModel;
using System.Configuration;
using PdfDocumentHandler.Models;
using PdfDocumentHandler.UserControls;


namespace PdfDocumentHandler;

public partial class PdfDocumentHandlerForm : Form
{
    private readonly PdfDocumentHandlerSettings _pdfDocumentHandlerSettings = new PdfDocumentHandlerSettings();


    public PdfDocumentHandlerForm()
    {
        InitializeComponent();
    }


    private void PdfDocumentHandlerForm_Load(object sender, EventArgs e)
    {
        KeyUp += sourceControl.SourceControl_KeyUp;

        //Associate settings property event handlers.
        _pdfDocumentHandlerSettings.SettingChanging += pdfDocumentHandlerSettings_SettingChanging;
        _pdfDocumentHandlerSettings.SettingsSaving  += pdfDocumentHandlerSettings_SettingsSaving;

        //Data bind settings properties with straightforward associations.
        var bndLocation = new Binding("Location", _pdfDocumentHandlerSettings, "FormLocation", true, DataSourceUpdateMode.OnPropertyChanged);
        DataBindings.Add(bndLocation);

        LoadSettings();
    }


    private static void pdfDocumentHandlerSettings_SettingChanging(object sender, SettingChangingEventArgs e)
    {
        //var settingName = e.SettingName;
        //var newValue = e.NewValue;
    }


    private static void pdfDocumentHandlerSettings_SettingsSaving(object sender, CancelEventArgs e)
    {
        //Should check for settings changes first.
        //var dialogResult = MessageBox.Show(@"Save current values for application settings?", @"Save Settings", MessageBoxButtons.YesNo);
        //
        //if (DialogResult.No == dialogResult)
        //{
        //    e.Cancel = true;
        //}
    }


    private void PdfDocumentHandlerForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveSettings();
    }


    private void buttonReset_Click(object sender, EventArgs e)
    {
        sourceControl.Clear();
        destinationControl.Clear();

        _pdfDocumentHandlerSettings.SourceFolders = new List<string>();
        _pdfDocumentHandlerSettings.Destinations = new List<Destination>();
        _pdfDocumentHandlerSettings.Reset();
        _pdfDocumentHandlerSettings.Save();

        Size = _pdfDocumentHandlerSettings.FormSize;
    }


    private void ButtonClose_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void SourceControl_CopyFile(object sender, CopyEventArgs e)
    {
        if (!destinationControl.CopyFile(e.FileName))
        {
            e.Canceled = true;
        }
    }


    private void SourceControl_MoveFile(object sender, MoveEventArgs e)
    {
        if (!destinationControl.MoveFile(e.FileName))
        {
            e.Canceled = true;
        }
    }


    private void SourceControl_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
    {
        if (!string.IsNullOrEmpty(e.FileName))
        {
            pdfViewerControl.SetPdf(e.FileName);
        }
        else
        {
            pdfViewerControl.Clear();
        }
    }

    #region Handling of settings

    private void LoadSettings()
    {
        if (_pdfDocumentHandlerSettings.UpgradeRequired)
        {
            _pdfDocumentHandlerSettings.Upgrade();
            _pdfDocumentHandlerSettings.UpgradeRequired = false;
            _pdfDocumentHandlerSettings.Save();
        }

        // Assign Size property, since databinding to Size doesn't work well.
        Size = _pdfDocumentHandlerSettings.FormSize;

        splitContainer1.SplitterDistance = _pdfDocumentHandlerSettings.SplitterDistance;
        sourceControl.SourceFolders      = _pdfDocumentHandlerSettings.SourceFolders;
        destinationControl.Destinations  = _pdfDocumentHandlerSettings.Destinations;
    }


    private void SaveSettings()
    {
        _pdfDocumentHandlerSettings.SourceFolders    = sourceControl.SourceFolders;
        _pdfDocumentHandlerSettings.Destinations     = destinationControl.Destinations.OrderBy(d => d.Name).ToList();
        _pdfDocumentHandlerSettings.FormSize         = Size;
        _pdfDocumentHandlerSettings.SplitterDistance = splitContainer1.SplitterDistance;

        _pdfDocumentHandlerSettings.Save();
    }

    #endregion
}
