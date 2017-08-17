using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace SDV502A1UnitTest
{
    [TestClass]
    public class InputParcelZoneColourAndWeight_Should
    {
        // Summary:
        // CalculateQuote() is used to get a price and the amount of excess tickets needed for a parcel of certain weight 
        // being delivered within a specified colour zone.

        // Parameters:
        // weight: Specifies the weight of the parcel to be delivered in kilograms.ArgumentOutOfRangeException thrown if the weight 
        // is 0 or less. ArgumentOutOfRangeException thrown if the weight is greater than 25.
        // zone: Specifies the coloured zone where the parcel is to be delivered.KeyNotFoundException thrown if the delivery zone 
        // doesn't exist or is invalid.

        // Returns:
        // An object containing the total quoted price, and number of excess tickets to be used.

        ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();

        Decimal Weight = 24.999m;

        [TestMethod]
        public void ReturnExcessTicketsAndPrice_WhenZoneIsBlueAndWeightIsX()
        {
            // Arrange
            //ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            ParcelQuoteResult ActualParcelQuote = pqfn.CalculateQuote(Weight, "Blue");
            // Assert
            Assert.AreEqual(0, ActualParcelQuote.ExcessTickets);
            Assert.AreEqual(6.95m, ActualParcelQuote.Price);

        }

        [TestMethod]
        public void ReturnExcessTicketsAndPrice_WhenZoneIsPinkAndWeightIsX()
        {
            // Arrange
            //ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            ParcelQuoteResult ActualParcelQuote = pqfn.CalculateQuote(Weight, "Pink");
            // Assert
            Assert.AreEqual(0, ActualParcelQuote.ExcessTickets);
            Assert.AreEqual(4.15m, ActualParcelQuote.Price);

        }
        
        [TestMethod]
        public void ReturnExcessTicketsAndPrice_WhenZoneIsOrangeAndWeightIsX()
        {
            // Arrange
            //ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            ParcelQuoteResult ActualParcelQuote = pqfn.CalculateQuote(Weight, "Orange");
            // Assert
            Assert.AreEqual(2, ActualParcelQuote.ExcessTickets);
            Assert.AreEqual(25.35m, ActualParcelQuote.Price);

        }

        [TestMethod]
        public void ReturnExcessTicketsAndPrice_WhenZoneIsLimeAndWeightIsX()
        {
            // Arrange
            //ParcelQuoteFromNelson pqfn = new ParcelQuoteFromNelson();
            // Act
            ParcelQuoteResult ActualParcelQuote = pqfn.CalculateQuote(Weight, "Lime");
            // Assert
            Assert.AreEqual(1, ActualParcelQuote.ExcessTickets);
            Assert.AreEqual(14.90m, ActualParcelQuote.Price);

        }
    }
}
