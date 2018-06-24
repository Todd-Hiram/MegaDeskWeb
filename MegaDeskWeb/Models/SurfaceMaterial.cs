using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway.Models
{
  public class SurfaceMaterial
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public SurfaceMaterial(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }

}
