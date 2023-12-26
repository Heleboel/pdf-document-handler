using PdfDocumentHandler.Models;
using Xunit;


namespace PdfDocumentHandler.UnitTest.Models;

public class DestinationTest
{
    [Fact]
    public void Copies_Destination_With_Copy_Constructor_Test()
    {
        // Arrange
        var destination = new Destination
        {
            Name              = "Test1",
            Description       = "Description1",
            Location          = "Location1",
            AddYearToLocation = true,
            Template          = "Template1"
        };

        // Act
        var destinationCopy = new Destination(destination);

        // Assert
        Assert.NotEqual(destination.Id, destinationCopy.Id);
        Assert.Equal(destination.Name, destinationCopy.Name);
        Assert.Equal(destination.Description, destinationCopy.Description);
        Assert.Equal(destination.Location, destinationCopy.Location);
        Assert.Equal(destination.Template, destinationCopy.Template);
        Assert.Equal(destination.AddYearToLocation, destinationCopy.AddYearToLocation);
    }


    [Fact]
    public void When_Called_With_Null_Returns_Empty_Destination_Test()
    {
        // Act
        var destinationCopy = new Destination();

        // Assert
        Assert.NotEmpty(destinationCopy.Id);
        Assert.Empty(destinationCopy.Name);
        Assert.Empty(destinationCopy.Description);
        Assert.Empty(destinationCopy.Location);
        Assert.Empty(destinationCopy.Template);
        Assert.False(destinationCopy.AddYearToLocation);
    }
}
