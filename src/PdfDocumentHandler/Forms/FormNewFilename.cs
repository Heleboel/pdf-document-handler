using System.Globalization;
using PdfDocumentHandler.Models;
using PdfDocumentHandler.Resolvers;


namespace PdfDocumentHandler.Forms;

public partial class FormNewFilename : Form
{
    private const string KeyDate        = "Datum";
    private const string KeyCompany     = "Bedrijf";
    private const string KeyDescription = "Omschrijving";
    private const string KeyMonth       = "Maand";
    private const string KeyMonthName   = "MaandNaam";
    private const string KeyYear        = "Jaar";

    private readonly Destination _destination = new();


    private FormNewFilename()
    {
        InitializeComponent();

        if (FormLocation.Equals(new Point(0, 0)))
        {
            StartPosition = FormStartPosition.CenterParent;
        }
        else
        {
            StartPosition = FormStartPosition.Manual;
            Location      = FormLocation;
            Size          = FormSize;
        }
    }


    public FormNewFilename(
        string sourceFile,
        Destination destination
    ) : this()
    {
        _destination = destination;

        labelDestinationNameText.Text   = destination.Name;
        labelDestinationFolderText.Text = destination.Location;
        textBoxOriginalFileName.Text    = Path.GetFileName(sourceFile);

        var nameTemplate = _destination.Template;
        textBoxNewFileName.Text = string.IsNullOrEmpty(nameTemplate) ? Path.GetFileName(sourceFile) : nameTemplate;

        UpdatePreview();
    }


    public string GetNewFileName()
    {
        var newFileName = ComposeNewFileName(textBoxNewFileName.Text);
        var year        = _destination.AddYearToLocation ? dateTimePicker.Value.Year.ToString() : "";

        return Path.Combine(_destination.Location, year, newFileName);
    }


    private void TextBoxNewFileName_TextChanged(object sender, EventArgs e)
    {
        UpdatePreview();
    }


    private void DateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        UpdatePreview();
    }


    private void TextBoxCompany_TextChanged(object sender, EventArgs e)
    {
        UpdatePreview();
    }


    private void TextBoxDescription_TextChanged(object sender, EventArgs e)
    {
        UpdatePreview();
    }


    private void UpdatePreview()
    {
        labelPreviewText.Text = GetNewFileName();
    }


    private string ComposeNewFileName(string template)
    {
        var templateResolver = new TemplateResolver(template);

        var values = new Dictionary<string, object>
        {
            { KeyDate,        dateTimePicker.Value },
            { KeyCompany,     textBoxCompany.Text },
            { KeyDescription, textBoxDescription.Text },
            { KeyMonth,       dateTimePicker.Value.Month },
            { KeyMonthName,   CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dateTimePicker.Value.ToString("MMMM")) },
            { KeyYear,        dateTimePicker.Value.Year }
        };

        var newFileName = templateResolver.Resolve(textBoxOriginalFileName.Text, values);

        return newFileName;
    }


    #region Form events

    private static Point FormLocation { get; set; }
    private static Size FormSize { get; set; }

    private void FormNewFilename_Move(object sender, EventArgs e)
    {
        FormLocation = Location;
    }

    private void FormNewFilename_Resize(object sender, EventArgs e)
    {
        FormSize = Size;
    }

    #endregion
}
