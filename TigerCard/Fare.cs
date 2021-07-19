using System.Collections.Generic;
using System.Linq;

namespace TigerCard
{
    public class Fare
    {
        private List<ZoneFare> zoneFareList = new List<ZoneFare>();

        public Fare()
        {
            zoneFareList.Add(new ZoneFare(true, Zone.Zone1, Zone.Zone1, 30));
            zoneFareList.Add(new ZoneFare(true, Zone.Zone2, Zone.Zone2, 25));
            zoneFareList.Add(new ZoneFare(true, Zone.Zone1, Zone.Zone2, 35));
            zoneFareList.Add(new ZoneFare(true, Zone.Zone2, Zone.Zone1, 35));

            zoneFareList.Add(new ZoneFare(false, Zone.Zone1, Zone.Zone1, 25));
            zoneFareList.Add(new ZoneFare(false, Zone.Zone2, Zone.Zone2, 20));
            zoneFareList.Add(new ZoneFare(false, Zone.Zone1, Zone.Zone2, 30));
            zoneFareList.Add(new ZoneFare(false, Zone.Zone2, Zone.Zone1, 30));
        }

        public int getFare(bool isPeakHour, Zone fromZone, Zone toZone)
        {
            return zoneFareList.Where(x => x.isPeakHourMatch(isPeakHour)).Where(y => y.zoneMatch(fromZone, toZone)).
                 Select(i => i.getFare()).FirstOrDefault();
        }


        public class ZoneFare
        {
            private bool isPeakHour;
            private Zone fromZone;
            private Zone toZone;
            private int fare;

            public ZoneFare(bool isPeakHour, Zone fromZone, Zone toZone, int fare)
            {
                this.isPeakHour = isPeakHour;
                this.fromZone = fromZone;
                this.toZone = toZone;
                this.fare = fare;
            }

            public bool zoneMatch(Zone fromZone, Zone toZone)
            {
                return this.fromZone == fromZone &&
                        this.toZone == toZone;
            }

            public bool isPeakHourMatch(bool isPeakHour)
            {
                return this.isPeakHour == isPeakHour;
            }

            public int getFare()
            {
                return this.fare;
            }
        }
    }
}
