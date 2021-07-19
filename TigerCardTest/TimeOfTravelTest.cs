using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TigerCard;

namespace TigerCardTest
{
    [TestClass]
    public class TimeOfTravelTest
    {
        [TestMethod]
        
    public void itShouldReturn_PeakHour_WhenIts_Weekday_MorningTimeWindow_LowerNominal()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("07:00"), Zone.Zone1, Zone.Zone2)
            );

            Assert.IsTrue(timeOfTravel.isPeakHourTravel());
            
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekday_MorningTimeWindow_UpperNominal()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Tuesday, DateTime.Parse("10:30"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_MorningTimeWindow_BelowMinimum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("06:59"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekday_MorningTimeWindow_AboveMinimum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("07:01"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekday_MorningTimeWindow_BelowMaximum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("10:29"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_MorningTimeWindow_AboveMaximum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("10:31"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekend_MorningTimeWindow_LowerNominal()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("09:00"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekend_MorningTimeWindow_UpperNominal()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Sunday, DateTime.Parse("11:00"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_MorningTimeWindow_BelowMinimum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("08:59"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekend_MorningTimeWindow_AboveMinimum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("09:01"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_PeakHour_WhenIts_Weekend_MorningTimeWindow_BelowMaximum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("10:59"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_MorningTimeWindow_AboveMaximum()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("11:01"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_LowerNominal_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("17:00"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_UpperNominal_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("20:00"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_BelowMinimum_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("16:59"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_LowerNominal_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Sunday, DateTime.Parse("18:00"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_UpperNominal_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Sunday, DateTime.Parse("22:00"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_BelowMinimum_PolicyOneTrue()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("17:59"), Zone.Zone2, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_LowerNominal_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("17:00"), Zone.Zone2, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_UpperNominal_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("20:00"), Zone.Zone2, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_EveningTimeWindow_BelowMinimum_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Monday, DateTime.Parse("16:59"), Zone.Zone1, Zone.Zone1)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_LowerNominal_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Sunday, DateTime.Parse("18:00"), Zone.Zone1, Zone.Zone1)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_UpperNominal_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Sunday, DateTime.Parse("22:00"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsTrue(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_EveningTimeWindow_BelowMinimum_PolicyOneFalse()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("17:59"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekend_NoTimeWindow()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek. Saturday, DateTime.Parse("15:39"), Zone.Zone1, Zone.Zone2)
            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }

        [TestMethod]
    public void itShouldReturn_OffPeakHour_WhenIts_Weekday_NoTimeWindow()
        {
            TimeOfTravel timeOfTravel = new TimeOfTravel(
                    new Journey(DayOfWeek.Friday, DateTime.Parse("01:11"), Zone.Zone1, Zone.Zone2)

            );

             Assert.IsFalse(timeOfTravel.isPeakHourTravel());
        }
    }
}
