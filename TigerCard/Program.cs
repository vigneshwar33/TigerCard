using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerCard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Journey> journeys = new List<Journey>();
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Monday, DateTime.Parse("07:01"), Zone.Zone2, Zone.Zone1));

            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Tuesday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Wednesday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Friday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Saturday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));

            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("10:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("14:22"), Zone.Zone2, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("15:22"), Zone.Zone1, Zone.Zone1));
            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("16:22"), Zone.Zone1, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));
            journeys.Add(new Journey(DayOfWeek.Sunday, DateTime.Parse("20:22"), Zone.Zone2, Zone.Zone2));


            FareCalculator fareCalculator = new FareCalculator(journeys);           
            Console.WriteLine(string.Format("Amount to be paid for this week is: {0}", fareCalculator.getCalculatedFare()));
           // Console.ReadKey();

        }
    }
}
