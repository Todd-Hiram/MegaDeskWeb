using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway.Models
{
   public class RushOrder
    {
        public string Name { get; set; }
        
        public decimal HighCost { get; set; }
        public decimal MediumCost { get; set; }
        public decimal LowCost { get; set; }

        public RushOrder(string name, decimal highCost, decimal mediumCost, decimal lowCost)
        {
            Name = name;
           HighCost = highCost;
            MediumCost = mediumCost;
            LowCost = lowCost;

        }

        internal decimal GetCost(Desk desk)
        {
            //1. get surface size

            var surfaceArea = desk.GetSurfaceArea();
            
            //2. get cost
            if (surfaceArea <1000)
            {
                return LowCost;
            }
            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                return MediumCost;
            }
            return HighCost;
        }
    }
}
