using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TigerCard;

namespace TigerCardTest
{
    [TestClass]
    public class CappingTest
    {
        [TestMethod]
        public void itShouldReturnDailyCap100WhenFromZoneOneAndToZoneOne()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getDailyCap(Zone.Zone1, Zone.Zone1), 100);
        }
        [TestMethod]
        public void itShouldReturnDailyCap80WhenFromZoneTwoAndToZoneTwo()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getDailyCap(Zone.Zone2, Zone.Zone2), 80);

        }

        [TestMethod]
        public void itShouldReturnDailyCap120WhenFromZoneOneAndToZoneTwo()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getDailyCap(Zone.Zone1, Zone.Zone2), 120);

        }

        [TestMethod]
        public void itShouldReturnDailyCap120WhenFromZoneTwoAndToZoneOne()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getDailyCap(Zone.Zone2, Zone.Zone1), 120);

        }

        [TestMethod]
        public void itShouldReturnWeeklyCap100WhenFromZoneOneAndToZoneOne()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getWeeklyCap(Zone.Zone1, Zone.Zone1), 500);

        }

        [TestMethod]
        public void itShouldReturnWeeklyCap80WhenFromZoneTwoAndToZoneTwo()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getWeeklyCap(Zone.Zone2, Zone.Zone2), 400);

        }

        [TestMethod]
        public void itShouldReturnWeeklyCap120WhenFromZoneOneAndToZoneTwo()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getWeeklyCap(Zone.Zone1, Zone.Zone2), 600);

        }

        [TestMethod]
        public void itShouldReturnWeeklyCap120WhenFromZoneTwoAndToZoneOne()
        {
            Capping capping = new Capping();

            Assert.AreEqual(capping.getWeeklyCap(Zone.Zone2, Zone.Zone1), 600);

        }

        [TestMethod]
        public void itShouldReturn120AsMaxDailyCap()
        {
            Capping capping = new Capping();
            List<Journey> journeys = new List<Journey>();
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            int maxDailyCap = capping.getMaximumDailyCap(journeys);

            Assert.AreEqual(maxDailyCap, 120);
        }

        [TestMethod]
        public void itShouldReturn100AsMaxDailyCap()
        {
            Capping capping = new Capping();
            List<Journey> journeys = new List<Journey>();
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("15:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("16:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            int maxDailyCap = capping.getMaximumDailyCap(journeys);

            Assert.AreEqual(maxDailyCap, 100);
        }
        [TestMethod]
        public void itShouldReturn600AsMaxWeeklyCap()
        {
            Capping capping = new Capping();
            List<Journey> journeys = new List<Journey>();
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            int maxWeeklyCap = capping.getMaximumWeeklyCap(journeys);

            Assert.AreEqual(maxWeeklyCap, 600);
        }

        [TestMethod]
        public void itShouldReturn500AsMaxWeeklyCap()
        {
            Capping capping = new Capping();
            List<Journey> journeys = new List<Journey>();
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            int maxWeeklyCap = capping.getMaximumWeeklyCap(journeys);

            Assert.AreEqual(maxWeeklyCap, 500);
        }
    }
}
