using PdfDocumentHandler.Resolvers;
using Xunit;


namespace PdfDocumentHandler.UnitTest.Resolvers;

public class TemplateResolverTest
{
    [Fact]
    public void Returns_Filename_When_No_Template_Applied_Test()
    {
        // Arrange
        var templateResolver = new TemplateResolver();

        // Act
        var resolvedString = templateResolver.Resolve("OriginalFilename.pdf", new Dictionary<string, object>());

        // Assert
        Assert.Equal("OriginalFilename.pdf", resolvedString);
    }


    [Fact]
    public void Constructor_Needs_Template_Test()
    {
        // Arrange & Act
        var templateResolver = new TemplateResolver("template");

        // Assert
        Assert.Equal("template", templateResolver.Template);
    }


    [Fact]
    public void TemplateResolver_Can_Resolve_Template_Test()
    {
        // Arrange
        const string filename = "filename";
        var templateResolver = new TemplateResolver("template");

        // Act
        var resolvedString = templateResolver.Resolve(filename, new Dictionary<string, object>());

        // Assert
        Assert.Equal("template", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Replaces_Date_With_Date_Test()
    {
        // Arrange
        const string filename = "filename";
        var templateResolver = new TemplateResolver("{Datum}");

        // Act
        var resolvedString = templateResolver.Resolve(filename,
            new Dictionary<string, object> { { "Datum", new DateTime(2017, 03, 09) } });

        // Assert
        Assert.Equal("2017-03-09", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Replaces_Description_With_Description_Test()
    {
        // Arrange
        const string filename = "filename";
        var templateResolver = new TemplateResolver("{Omschrijving}");

        // Act
        var resolvedString = templateResolver.Resolve(filename,
            new Dictionary<string, object> { { "Omschrijving", "Dit is een omschrijving" } });

        // Assert
        Assert.Equal("Dit is een omschrijving", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Replaces_Both_Date_And_Description_Test()
    {
        // Arrange
        const string filename = "filename";
        var templateResolver = new TemplateResolver("{Datum} {Omschrijving}");

        // Act
        var resolvedString = templateResolver.Resolve(filename, new Dictionary<string, object>
        {
            { "Datum", new DateTime(2017, 03, 09) },
            { "Omschrijving", "Dit is een omschrijving" }
        });

        // Assert
        Assert.Equal("2017-03-09 Dit is een omschrijving", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Replaces_Both_Date_And_Description_And_Trims_Test()
    {
        // Arrange
        const string filename = "filename";
        var templateResolver = new TemplateResolver("{Datum} {Omschrijving}");

        // Act
        var resolvedString = templateResolver.Resolve(filename, new Dictionary<string, object>
        {
            { "Datum", new DateTime(2017, 03, 09) },
            { "Omschrijving", "" }
        });

        // Assert
        Assert.Equal("2017-03-09", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Accepts_And_Resolves_RegEx_Test()
    {
        // Arrange
        const string filename = "NS-2017000001.pdf";
        var templateResolver = new TemplateResolver("NS Factuur {RegEx:[0-9]+}");

        // Act
        var resolvedString = templateResolver.Resolve(filename);

        // Assert
        Assert.Equal("NS Factuur 2017000001", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Accepts_And_Resolves_RegEx_With_Multiple_Keys_Test()
    {
        // Arrange
        const string filename = "NS-2017000001.pdf";
        var templateResolver = new TemplateResolver("{Datum} NS Factuur {RegEx:[0-9]+} ({Maand}-{Jaar})");

        // Act
        var resolvedString = templateResolver.Resolve(filename, new Dictionary<string, object>
        {
            { "Datum", new DateTime(2017, 03, 20) },
            { "Maand", 3 },
            { "Jaar", 2017 }
        });

        // Assert
        Assert.Equal("2017-03-20 NS Factuur 2017000001 (3-2017)", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Accepts_And_Resolves_Formatting_DateTimes_Test()
    {
        // Arrange
        var templateResolver = new TemplateResolver("{Datum:dd-MM-yyyy}");

        // Act
        var resolvedString = templateResolver.Resolve("img-20170328.pdf",
            new Dictionary<string, object> { { "Datum", new DateTime(2017, 3, 28) } });

        // Assert
        Assert.Equal("28-03-2017", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Accepts_And_Resolves_Formatting_Integers_Test()
    {
        // Arrange
        var templateResolver = new TemplateResolver("{Maand:00}");

        // Act
        var resolvedString =
            templateResolver.Resolve("img-20170328.pdf", new Dictionary<string, object> { { "Maand", 1 } });

        // Assert
        Assert.Equal("01", resolvedString);
    }


    [Fact]
    public void TemplateResolver_Accepts_And_Resolves_Formatting_With_Multiple_Keys_Test()
    {
        // Arrange
        var templateResolver = new TemplateResolver("{Maand:00} ({MaandNaam})");

        // Act
        var resolvedString = templateResolver.Resolve("img-20170328.pdf",
            new Dictionary<string, object> { { "Maand", 1 }, { "MaandNaam", "Januari" } });

        // Assert
        Assert.Equal("01 (Januari)", resolvedString);
    }
}
