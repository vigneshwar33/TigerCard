using System;

namespace TigerCard
{
   public class Journey
    {
        public DayOfWeek dayOfWeek;
        public DateTime time;
        public Zone fromZone;
        public Zone toZone;

     public  Journey(DayOfWeek dayOfWeek, DateTime time, Zone fromZone, Zone toZone)
        {
            this.dayOfWeek = dayOfWeek;
            this.time = time;
            this.fromZone = fromZone;
            this.toZone = toZone;
        }

        public DayOfWeek getDayOfWeek()
        {
            return dayOfWeek;
        }

        public DateTime getTime()
        {
            return time;
        }

        public Zone getFromZone()
        {
            return fromZone;
        }

        public Zone getToZone()
        {
            return toZone;
        }
    }
}
