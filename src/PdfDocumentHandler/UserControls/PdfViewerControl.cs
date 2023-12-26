using System.Drawing.Text;
using System.Runtime.InteropServices;
using Spire.Pdf;


namespace PdfDocumentHandler.UserControls;

public partial class PdfViewerControl : UserControl
{
    // Spire only allows the first three pages to be converted into an image.
    private const int MaxNumberOfPages = 3;

    private Font _fontAwesome;

    private int         _currentPageNumber;
    private PdfDocument _pdfDocument;
    private readonly List<string> _excludedFileNames = new List<string>();


    [DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);


    public PdfViewerControl()
    {
        InitializeComponent();
        InitializeFont();

        buttonRotateLeft.Font      = _fontAwesome;
        buttonRotateLeft.Text      = @"";
        buttonRotateLeft.Enabled   = false;
        buttonRotateRight.Font     = _fontAwesome;
        buttonRotateRight.Text     = @"";
        buttonRotateRight.Enabled  = false;
        buttonNextPage.Font        = _fontAwesome;
        buttonNextPage.Text        = @"";
        buttonNextPage.Enabled     = false;
        buttonPreviousPage.Font    = _fontAwesome;
        buttonPreviousPage.Text    = @"";
        buttonPreviousPage.Enabled = false;

        _currentPageNumber = 1;
        _pdfDocument       = null;
    }


    /// <summary>
    /// Initializes the "FontAwesome" used for some icons on buttons and so on.
    /// It adds the font to the 'system' (with AddFontMemResourceEx) otherwise
    /// showing the icons will screw up.
    /// </summary>
    private void InitializeFont()
    {
        var fontLength = Properties.Resources.fontawesome_webfont.Length;
        var fontData = Properties.Resources.fontawesome_webfont;

        var data = Marshal.AllocCoTaskMem(fontLength);

        // copy the bytes to the unsafe memory block
        Marshal.Copy(fontData, 0, data, fontLength);

        // Pass the font to the font collection
        var privateFontCollection = new PrivateFontCollection();
        privateFontCollection.AddMemoryFont(data, fontLength);

        // Add the font to the system
        uint cFonts = 0;
        AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

        // Free up the unsafe memory
        Marshal.FreeCoTaskMem(data);

        _fontAwesome = new Font(privateFontCollection.Families[0], 10.0f, FontStyle.Regular);
    }


    public void SetPdf(string filename)
    {
        if (!IsValidFilename(filename))
        {
            Clear();

            buttonRotateLeft.Enabled   = false;
            buttonRotateRight.Enabled  = false;
            buttonNextPage.Enabled     = false;
            buttonPreviousPage.Enabled = false;

            return;
        }

        try
        {
            _pdfDocument = new PdfDocument();
            _pdfDocument.LoadFromFile(filename);

            buttonRotateLeft.Enabled = true;
            buttonRotateRight.Enabled = true;

            UpdatePagesLabel();
            UpdateGotoButtons();
            ShowPdf();
        }
        catch (Exception exception)
        {
            if (exception.Message.Contains("limit"))
            {
                AddExcludedFilename(filename);
                Clear();
                MessageBox.Show(this, exception.Message);
            }
            else
            {
                throw;
            }
        }
    }


    private bool IsValidFilename(string filename)
    {
        if (string.IsNullOrEmpty(filename))
        {
            return false;
        }
        if (_excludedFileNames.Contains(filename))
        {
            return false;
        }
        if (!File.Exists(filename))
        {
            return false;
        }
        return true;
    }


    private void AddExcludedFilename(string filename)
    {
        if (!_excludedFileNames.Contains(filename))
        {
            _excludedFileNames.Add(filename);
        }
    }


    private void ShowPdf()
    {
        var numberOfPages = NumberOfPages;
        int index;

        if (_currentPageNumber >= numberOfPages)
        {
            index = numberOfPages - 1;
        }
        else if (_currentPageNumber < 1)
        {
            index = 0;
        }
        else
        {
            index = _currentPageNumber - 1;
        }

        pictureBoxPdfImage.Image = _pdfDocument.SaveAsImage(index);
    }


    private int NumberOfPages
    {
        get
        {
            if (_pdfDocument != null)
            {
                return Math.Min(MaxNumberOfPages, _pdfDocument.Pages.Count);
            }
            return 0;
        }
    }


    private void UpdateGotoButtons()
    {
        var numberOfPages = NumberOfPages;

        buttonPreviousPage.Enabled = _currentPageNumber > 1;
        buttonNextPage.Enabled     = _currentPageNumber < numberOfPages;
    }


    private void UpdatePagesLabel()
    {
        // Show the real number of pages.
        var numberOfPages = _pdfDocument.Pages.Count;
        labelPages.Text = $@"Pagina {_currentPageNumber}/{numberOfPages}";
    }


    private void GotoNextPage()
    {
        var numberOfPages = NumberOfPages;

        if (_currentPageNumber < numberOfPages)
        {
            _currentPageNumber++;
        }

        UpdatePagesLabel();
        UpdateGotoButtons();
        ShowPdf();
    }


    private void GotoPreviousPage()
    {
        if (_currentPageNumber > 1)
        {
            _currentPageNumber--;
        }

        UpdatePagesLabel();
        UpdateGotoButtons();
        ShowPdf();
    }


    private void buttonPreviousPage_Click(object sender, EventArgs e)
    {
        GotoPreviousPage();
    }


    private void buttonNextPage_Click(object sender, EventArgs e)
    {
        GotoNextPage();
    }


    #region Rotate pdf.

    private void buttonRotateCounterClockWise_Click(object sender, EventArgs e)
    {
        var image = pictureBoxPdfImage.Image;
        image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        pictureBoxPdfImage.Image = image;
    }

    private void buttonRotateClockWise_Click(object sender, EventArgs e)
    {
        var image = pictureBoxPdfImage.Image;
        image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        pictureBoxPdfImage.Image = image;
    }

    #endregion


    public void Clear()
    {
        _currentPageNumber       = 1;
        _pdfDocument             = null;
        pictureBoxPdfImage.Image = null;
    }


    private void PdfViewerControl_Load(object sender, EventArgs e)
    {
    }
}
