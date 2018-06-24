using MegaDesk_3_Lisa_Conway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway
{
   public class Desk
    {

        public decimal BaseCost = 200;
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal NumberOfDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        //depth, numberOfDrawers,
      
        public decimal GetSurfaceArea()
        {
            return Width * Depth;
        }
    }
}
