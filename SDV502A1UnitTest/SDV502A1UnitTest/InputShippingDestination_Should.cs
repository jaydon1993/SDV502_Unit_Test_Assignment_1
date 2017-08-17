using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDV502A1UnitTest
{
    [TestClass]
    public class InputShippingDestination_Should
    {

        //Summary:
        //GetDestinationZone() is used to lookup the the coloured zone for pricing of a specified delivery destination - town, 
        // city, etc.

        // Parameters:
        // destination: Specifies the location where a parcel may be delivered - town, city, etc.KeyNotFoundException 
        // is thrown if the destination specified does not exist or is invalid.

        // Returns:
        // A string value containing the coloured zone where the specified destination location exists.

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsTakaka()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Takaka");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsHavelock()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Havelock");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsRiwaka()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Riwaka");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsSeddon()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Seddon");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsWard()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Ward");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsWaihopaiValley()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Waihopai Valley");
            // Assert
            Assert.AreEqual("Blue", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsMotueka()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Motueka");
            // Assert
            Assert.AreEqual("Pink", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsAtawhai()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Atawhai");
            // Assert
            Assert.AreEqual("Pink", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsMapua()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Mapua");
            // Assert
            Assert.AreEqual("Pink", ActualZone);
        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsNelson()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Nelson");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsMaitai()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Maitai");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsHope()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Hope");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsBrightwater()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Brightwater");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsWakefield()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Wakefield");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsPicton()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Picton");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsRenwick()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Renwick");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsBlenheim()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Blenheim");
            // Assert
            Assert.AreEqual("Pink", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsMurchison()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Murchison");
            // Assert
            Assert.AreEqual("Lime", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsNelsonLakes()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Nelson Lakes");
            // Assert
            Assert.AreEqual("Lime", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsKaikoura()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Kaikoura");
            // Assert
            Assert.AreEqual("Orange", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsReefton()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Reefton");
            // Assert
            Assert.AreEqual("Orange", ActualZone);


        }

        [TestMethod]
        public void ReturnDestinationZoneColour_WhenDestinationIsHanmerSprings()
        {
            // Arrange
            ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            string ActualZone = pqfn.GetDestinationZone("Hanmer Springs");
            // Assert
            Assert.AreEqual("Orange", ActualZone);


        }
    }
}