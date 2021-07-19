using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerCard
{
    public class ZonePolicies
    {
        private Zone fromZone;
        private Zone toZone;

        public ZonePolicies(Journey journey)
        {
            this.fromZone = journey.getFromZone();
            this.toZone = journey.getToZone();
        }

        public bool isPolicyOneTrue()
        {
            return this.fromZone != Zone.Zone1 &&
                    this.toZone == Zone.Zone1;
        }
    }
}
