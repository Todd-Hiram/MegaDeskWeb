using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway.Models
{
    class RushOrderFactory
    {
        public static List<RushOrder> GetRushOrder()
        {
            var results = new List<RushOrder>();
            results.Add(new RushOrder("3 Days", 60, 70, 80));
            results.Add(new RushOrder("5 Days", 40, 50, 60));
            results.Add(new RushOrder("7 Days", 30,35,40));
            results.Add(new RushOrder("Standard", 0,0,0));
            
            return results;
        }
    }
}
