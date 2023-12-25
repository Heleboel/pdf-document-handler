namespace PdfDocumentHandler.Models;

[Serializable]
public class Destination
{
    /// <summary>
    /// A Guid identifier for this destination.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The name of this destination to identify it.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// An optional description to describe this destination.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The location (path) of the destination.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// Whether the year must be added to the directory path (location).
    /// The year comes from the date (as per the template).
    /// </summary>
    public bool AddYearToLocation { get; set; }

    /// <summary>
    /// The template to change the name of the file.
    /// </summary>
    public string Template { get; set; }


    // Template:
    // "Brief {Datum} {Onderwerp}.pdf"
    // "Rekening {Datum} {Bedrijf} {Omschrijving}.pdf"
    // "Solcon_Factuur_{Datum}_{Factuurnummer}.pdf"
    // "NS_Factuur-{Datum}-{Factuurnummer}.pdf"
    // Werken met RegEx???


    /// <summary>
    /// Constructor.
    /// </summary>
    public Destination()
    {
        Id                = $"{Guid.NewGuid():B}";
        Name              = string.Empty;
        Description       = string.Empty;
        Location          = string.Empty;
        AddYearToLocation = false;
        Template          = string.Empty;
    }


    /// <summary>
    /// Copy constructor. If a null argument is supplied, the constructor behaves as the default constructor.
    /// </summary>
    /// <param name="destination">The destination object to copy.</param>
    public Destination(Destination destination) : this()
    {
        Name              = destination.Name;
        Description       = destination.Description;
        Location          = destination.Location;
        AddYearToLocation = destination.AddYearToLocation;
        Template          = destination.Template;
    }
}
