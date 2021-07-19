using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TigerCard;

namespace TigerCardTest
{
    [TestClass]
    public class Faretest
    {
        [TestMethod]
    public void itShouldReturn30WhenFromZoneIsOneToZoneIsOneAndPeakHour()
        {
            Fare fare = new Fare();
            Assert.AreEqual(fare.getFare(true, Zone.Zone1, Zone.Zone1), 30);
        }

        [TestMethod]
    public void itShouldReturn25WhenFromZoneIsOneToZoneIsOneAndOffPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(false, Zone.Zone1, Zone.Zone1), 25);

        }

        [TestMethod]
    public void itShouldReturn25WhenFromZoneIsTwoToZoneIsTwoAndPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(true, Zone.Zone2, Zone.Zone2), 25);

        }

        [TestMethod]
    public void itShouldReturn20WhenFromZoneIsTwoToZoneIsTwoAndOffPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(false, Zone.Zone2, Zone.Zone2), 20);

        }

        [TestMethod]
    public void itShouldReturn35WhenFromZoneIsOneToZoneIsTwoAndPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(true, Zone.Zone1, Zone.Zone2), 35);
        }

        [TestMethod]
    public void itShouldReturn30WhenFromZoneIsOneToZoneIsTwoAndOffPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(false, Zone.Zone1, Zone.Zone2), 30);
        }

        [TestMethod]
    public void itShouldReturn35WhenFromZoneIsTwoToZoneIsOneAndPeakHour()
        {
            Fare fare = new Fare();

            Assert.AreEqual(fare.getFare(true, Zone.Zone2, Zone.Zone1), 35);
        }

        [TestMethod]
    public void itShouldReturn30WhenFromZoneIsTwoToZoneIsOneAndOffPeakHour()
        {
            Fare fare = new Fare();
            Assert.AreEqual(fare.getFare(false, Zone.Zone2, Zone.Zone1), 30);
        }

    }
}
