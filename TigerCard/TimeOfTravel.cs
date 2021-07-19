using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerCard
{
   public class TimeOfTravel
    {
    private  DayOfWeek dayOfWeek;
    private  DateTime time;
    private ZonePolicies zonePolicies;

        public TimeOfTravel(Journey journey)
        {
            this.dayOfWeek = journey.getDayOfWeek();
            this.time = journey.getTime();
            this.zonePolicies = new ZonePolicies(journey);
        }

        public static bool isWeekend(DayOfWeek dayOfWeek)
        {
            return dayOfWeek.Equals(DayOfWeek.Saturday) ||
                    dayOfWeek.Equals(DayOfWeek.Sunday);
        }

        public static bool isWeekdayMorningTimeFrame(DateTime time)
          
        {
            DateTime dt = DateTime.Now;
            TimeSpan time1 = new TimeSpan(6, 59, 0);
            TimeSpan time2 = new TimeSpan(10, 31, 0);

            if(time > dt.Date.Add(time1) && time < dt.Date.Add(time2))
            {
                return true;
            }
            else
            {
                return false;
            }
            
           
        }

        public static bool isWeekdayEveningTimeFrame(DateTime time)
        {
            DateTime dt = DateTime.Now;
            TimeSpan time1 = new TimeSpan(16, 59, 0);
            TimeSpan time2 = new TimeSpan(20, 01, 0);

            return (time > dt.Date.Add(time1) && time < dt.Date.Add(time2)) ? true : false;
        }

        public static bool isWeekendMorningTimeFrame(DateTime time)
        {
            DateTime dt = DateTime.Now;
            TimeSpan time1 = new TimeSpan(8, 59, 0);
            TimeSpan time2 = new TimeSpan(11, 01, 0);

            return (time > dt.Date.Add(time1) && time < dt.Date.Add(time2)) ? true : false;
        }

        public static bool isWeekendEveningTimeFrame(DateTime time)
        {
            DateTime dt = DateTime.Now;
            TimeSpan time1 = new TimeSpan(17, 59, 0);
            TimeSpan time2 = new TimeSpan(22, 01, 0);
            return (time > dt.Date.Add(time1) && time < dt.Date.Add(time2)) ? true : false;
        }

        public bool isPeakHourTravel()
        {
            if (isWeekend(this.dayOfWeek))
            {
                if (isWeekendMorningTimeFrame(this.time))
                {
                    return true;
                }
                else
                {
                    if (isWeekendEveningTimeFrame(this.time))
                    {
                        return !this.zonePolicies.isPolicyOneTrue();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            else
            {
                if (isWeekdayMorningTimeFrame(this.time))
                {
                    return true;
                }
                else
                {
                    if (isWeekdayEveningTimeFrame(this.time))
                    {
                        return !this.zonePolicies.isPolicyOneTrue();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
