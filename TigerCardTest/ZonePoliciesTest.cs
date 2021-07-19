using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TigerCard;

namespace TigerCardTest
{
    [TestClass]
    public class ZonePoliciesTest
    {
        [TestMethod]
    public void itShouldReturnTrueWhenFromZoneIsNotOneAndToZoneIsOne()
        {
            Journey journey = new Journey(
                    DayOfWeek.Monday, DateTime.Parse("18:15"), Zone.Zone2, Zone.Zone1
            );
            ZonePolicies zonePolicies = new ZonePolicies(journey);

            Assert.IsTrue(zonePolicies.isPolicyOneTrue());
        }

        [TestMethod]
    public void itShouldReturnFalseWhenFromZoneIsOneAndToZoneIsOne()
        {
            Journey journey = new Journey(
                    DayOfWeek.Monday, DateTime.Parse("18:15"), Zone.Zone1, Zone.Zone1
            );
            ZonePolicies zonePolicies = new ZonePolicies(journey);

            Assert.IsFalse(zonePolicies.isPolicyOneTrue());
        }

        [TestMethod]
    public void itShouldReturnFalseWhenFromZoneIsTwoAndToZoneIsTwo()
        {
            Journey journey = new Journey(
                    DayOfWeek.Monday, DateTime.Parse("18:15"), Zone.Zone2, Zone.Zone2
            );
            ZonePolicies zonePolicies = new ZonePolicies(journey);

            Assert.IsFalse(zonePolicies.isPolicyOneTrue());
        }
    }
}
