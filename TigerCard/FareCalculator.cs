using System;
using System.Collections.Generic;

namespace TigerCard
{
   public class FareCalculator
    {
        private DayOfWeek previousDayOfWeek;
        private int currentDailyCap;
        private int currentWeeklyCap;
        private int maxDailyCap;
        private int maxWeeklyCap;
        private int dailyFareTillNow;
        private int weeklyFareTillNow;
        private int dailyCappedFare;
        private int weeklyCappedFare;
        private int x;

        private List<Journey> journeys;
        private Capping capping;
        private Fare fare;


        public FareCalculator(List<Journey> journeys)
        {
            this.journeys = journeys;
            capping = new Capping();
            fare = new Fare();

            this.previousDayOfWeek = DayOfWeek.Monday;
            this.currentDailyCap = 0;
            currentWeeklyCap = 0;
            maxDailyCap = 0;
            maxWeeklyCap = 0;
            dailyFareTillNow = 0;
            weeklyFareTillNow = 0;
            dailyCappedFare = 0;
            weeklyCappedFare = 0;
            x = 0;
        }

        public int getCalculatedFare()
        {
            foreach (var journey in  journeys)
            {
                DayOfWeek currentDayOfWeek = journey.getDayOfWeek();
                Zone fromZone = journey.getFromZone();
                Zone toZone = journey.getToZone();
                TimeOfTravel timeOfTravel = new TimeOfTravel(journey);

                currentDailyCap = capping.getDailyCap(fromZone, toZone);
                currentWeeklyCap = capping.getWeeklyCap(fromZone, toZone);

                bool dayChanged = isDayChanged(previousDayOfWeek, currentDayOfWeek);
                if (dayChanged)
                {
                    maxDailyCap = 0;
                    dailyFareTillNow = 0;
                    x = Math.Max(dailyCappedFare, weeklyFareTillNow);
                }

                maxDailyCap = Math.Max(maxDailyCap, currentDailyCap);
                maxWeeklyCap = Math.Max(maxWeeklyCap, currentWeeklyCap);

                int standardFare = getStandardFare(timeOfTravel.isPeakHourTravel(), fromZone, toZone);
                dailyFareTillNow += standardFare;
                dailyCappedFare = getCappedFare(dailyFareTillNow, maxDailyCap);

                weeklyFareTillNow = x + dailyCappedFare;
                weeklyCappedFare = getCappedFare(weeklyFareTillNow, maxWeeklyCap);
                printWeeklyCap(
                        currentDailyCap,
                        maxDailyCap,
                        currentWeeklyCap,
                        maxWeeklyCap,
                        standardFare,
                        dailyCappedFare,
                        weeklyFareTillNow,
                        weeklyCappedFare
                );

                previousDayOfWeek = journey.getDayOfWeek();

            }

            return weeklyCappedFare;
        }

        public static void printWeeklyCap(
                int currentDailyCap,
                int maxDailyCap,
                int currentWeeklyCap,
                int maxWeeklyCap,
                int standardFare,
                int cappedDailyFare,
                int weeklyFareSoFar,
                int cappedWeeklyFare
        )
        {

            Console.WriteLine(string.Format("Current Daily Cap: {0}", currentDailyCap));
            Console.WriteLine(string.Format("Max Daily Cap: {0}", maxDailyCap));
            Console.WriteLine(string.Format("Current Weekly Cap: {0}", currentWeeklyCap));
            Console.WriteLine(string.Format("Max Weekly Cap: {0}", maxWeeklyCap));
            Console.WriteLine(string.Format("Standard Fare: {0}", standardFare));
            Console.WriteLine(string.Format("Capped Daily Fare: {0}", cappedDailyFare));
            Console.WriteLine(string.Format("Weekly Fare so far: {0}", weeklyFareSoFar));
            Console.WriteLine(string.Format("Capped Weekly Fare: {0}", cappedWeeklyFare));
            Console.WriteLine("\n");
        }

        public int getStandardFare(bool isPeakHourTravelled, Zone fromZone, Zone toZone)
        {
            return fare.getFare(isPeakHourTravelled, fromZone, toZone);
        }

        public int getCappedFare(int fareTillNow, int maxCap)
        {
            return Math.Min(fareTillNow, maxCap);
        }

        public bool isDayChanged(DayOfWeek previousDayOfWeek, DayOfWeek currentDayOfWeek)
        {
            return previousDayOfWeek != currentDayOfWeek;
        }


    }
}
