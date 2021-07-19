using System.Collections.Generic;
using System.Linq;

namespace TigerCard
{
    public class Capping
    {
        private List<CappingFare> cappingFareList = new List<CappingFare>();

        public Capping()
        {
            cappingFareList.Add(new CappingFare(Zone.Zone1, Zone.Zone1, 100, 500));
            cappingFareList.Add(new CappingFare(Zone.Zone2, Zone.Zone2, 80, 400));
            cappingFareList.Add(new CappingFare(Zone.Zone1, Zone.Zone2, 120, 600));
            cappingFareList.Add(new CappingFare(Zone.Zone2, Zone.Zone1, 120, 600));
        }

        public int getDailyCap(Zone fromZone, Zone toZone)
        {
            return cappingFareList.Where(x => x.zoneMatch(fromZone, toZone)).Select(y => y.getDailyCap()).FirstOrDefault();
        }

        public int getWeeklyCap(Zone fromZone, Zone toZone)
        {
            return cappingFareList.Where(x => x.zoneMatch(fromZone, toZone)).Select(y => y.getWeeklyCap()).FirstOrDefault();
        }

        public int getMaximumDailyCap(List<Journey> journeys)
        {
            List<int> dailyCaps = new List<int>();

            foreach (var x in journeys)
            {
                dailyCaps.Add(getDailyCap(x.getFromZone(), x.getToZone()));
            }

            return dailyCaps.Max();
        }

        public int getMaximumWeeklyCap(List<Journey> journeys)
        {
            List<int> weeklyCaps = new List<int>();

            foreach (var journey in journeys)
            {
                weeklyCaps.Add(getWeeklyCap(journey.getFromZone(), journey.getToZone()));
            }

            return weeklyCaps.Max();
        }


        public class CappingFare
        {
            public Zone fromZone;
            public Zone toZone;
            public int dailyCap;
            public int weeklyCap;

            public CappingFare(Zone fromZone, Zone toZone, int dailyCap, int weeklyCap)
            {
                this.fromZone = fromZone;
                this.toZone = toZone;
                this.dailyCap = dailyCap;
                this.weeklyCap = weeklyCap;
            }

            public bool zoneMatch(Zone fromZone, Zone toZone)
            {
                return this.fromZone == fromZone &&
                        this.toZone == toZone;
            }

            public int getDailyCap()
            {
                return this.dailyCap;
            }

            public int getWeeklyCap()
            {
                return this.weeklyCap;
            }
        }
    }
}
