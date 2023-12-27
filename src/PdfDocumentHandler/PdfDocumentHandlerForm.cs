using PdfDocumentHandler.Models;
using PdfDocumentHandler.UserControls;


namespace PdfDocumentHandler;

public partial class PdfDocumentHandlerForm : Form
{
    private readonly PdfDocumentHandlerSettings _pdfDocumentHandlerSettings = new();


    public PdfDocumentHandlerForm()
    {
        InitializeComponent();
    }


    private void PdfDocumentHandlerForm_Load(object sender, EventArgs e)
    {
        LoadSettings();

        sourceControl.RefreshFiles();

        KeyUp += sourceControl.SourceControl_KeyUp!;
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
        if (string.IsNullOrWhiteSpace(e.FileName))
        {
            return;
        }

        if (!destinationControl.CopyFile(e.FileName))
        {
            e.Canceled = true;
        }
    }


    private void SourceControl_MoveFile(object sender, MoveEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.FileName))
        {
            return;
        }

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
        if (_pdfDocumentHandlerSettings.FormState == FormWindowState.Maximized)
        {
            WindowState = _pdfDocumentHandlerSettings.FormState;
        }
        else
        {
            Location = _pdfDocumentHandlerSettings.FormLocation;
            Size     = _pdfDocumentHandlerSettings.FormSize;
        }

        splitContainer1.SplitterDistance = _pdfDocumentHandlerSettings.SplitterDistance;
        sourceControl.SourceFolders      = _pdfDocumentHandlerSettings.SourceFolders;
        destinationControl.Destinations  = _pdfDocumentHandlerSettings.Destinations;
    }


    private void SaveSettings()
    {
        _pdfDocumentHandlerSettings.SourceFolders    = sourceControl.SourceFolders;
        _pdfDocumentHandlerSettings.Destinations     = destinationControl.Destinations.OrderBy(d => d.Name).ToList();
        _pdfDocumentHandlerSettings.SplitterDistance = splitContainer1.SplitterDistance;

        if (WindowState == FormWindowState.Normal)
        {
            _pdfDocumentHandlerSettings.FormState    = WindowState;
            _pdfDocumentHandlerSettings.FormSize     = Size;
            _pdfDocumentHandlerSettings.FormLocation = Location;
        }
        else
        {
            _pdfDocumentHandlerSettings.FormState = WindowState;
        }

        _pdfDocumentHandlerSettings.Save();
    }

    #endregion
}
