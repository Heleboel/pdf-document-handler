using Microsoft.VisualStudio.TestTools.UnitTesting;

using PdfDocumentHandler.Models;


namespace PdfDocumentHandler.UnitTest.Models
{
    [TestClass]
    public class DestinationTest
    {
        [TestMethod]
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
            Assert.AreNotEqual(destination.Id, destinationCopy.Id);
            Assert.AreEqual(destination.Name, destinationCopy.Name);
            Assert.AreEqual(destination.Description, destinationCopy.Description);
            Assert.AreEqual(destination.Location, destinationCopy.Location);
            Assert.AreEqual(destination.Template, destinationCopy.Template);
            Assert.AreEqual(destination.AddYearToLocation, destinationCopy.AddYearToLocation);
        }


        [TestMethod]
        public void When_Called_With_Null_Returns_Empty_Destination_Test()
        {
            // Act
            var destinationCopy = new Destination(null);

            // Assert
            Assert.IsNotNull(destinationCopy.Id);
            Assert.IsNull(destinationCopy.Name);
            Assert.IsNull(destinationCopy.Description);
            Assert.IsNull(destinationCopy.Location);
            Assert.IsNull(destinationCopy.Template);
            Assert.IsFalse(destinationCopy.AddYearToLocation);
        }
    }
}
