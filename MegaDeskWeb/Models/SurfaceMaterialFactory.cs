using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway.Models
{
  public  class SurfaceMaterialFactory
    {
      public static List<SurfaceMaterial> GetSurfaceMaterials()
        {
            List<SurfaceMaterial> results = new List<SurfaceMaterial>();
            results.Add(new SurfaceMaterial("Pine", 50));
            results.Add(new SurfaceMaterial("Laminate", 100));
            results.Add(new SurfaceMaterial("Rosewood", 300));
            results.Add(new SurfaceMaterial("Oak", 200));
            results.Add(new SurfaceMaterial("Veneer", 125));
            return results;
        }
    }
}
