using MegaDesk_3_Lisa_Conway.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Lisa_Conway
{
    public class DeskQuote
    {

        public decimal FinalQuote { get; set; }
        public DateTime Date { get; set; }
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public RushOrder RushOrder { get; set; }

        public String RushOrderName
        {
            get
            {
                return RushOrder.Name;
            }
        }

        public decimal DeskDrawers
        {
            get
            {
                return Desk.NumberOfDrawers;
            }
        }
        public decimal Price
        {
            get
            {
                return GetTotal();
            }
        }

        public String SurfaceMaterialName
        {
            get
            {
                return Desk.SurfaceMaterial.Name;
            }
        }


        //constants
     
        public DeskQuote (String text)
        {
            Desk = new Desk();
            var fields = text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            CustomerName = fields[0];
            Desk.Width = decimal.Parse(fields[1]);
            Desk.Depth = decimal.Parse(fields[2]);
            Desk.SurfaceMaterial = new SurfaceMaterial(fields[3],decimal.Parse(fields[4]));
            
            Desk.NumberOfDrawers = decimal.Parse(fields[5]);
            RushOrder = new RushOrder(fields[6],decimal.Parse(fields[7]),decimal.Parse(fields[8]),decimal.Parse(fields[9]));
          
           Date =  DateTime.Parse(fields[10]);

           // CustomerName, Desk.Width,
            //    Desk.Depth, Desk.SurfaceMaterial.Name,Desk.SurfaceMaterial.Cost,
             //   Desk.NumberOfDrawers, RushOrder.Name,RushOrder.LowCost,RushOrder.MediumCost,RushOrder.HighCost, Date);

        }

        public DeskQuote()
        {
        }

        // const decimal
        //price, date



        public decimal GetBaseCost()
        {
            //variable
                return 0;
        }

        public decimal GetDrawerCost()
        {
            var drawers = Desk.NumberOfDrawers;
            var drawerCost = drawers * 50;
            return drawerCost;
        }

        public decimal GetSurfaceCost()
        {
            decimal surfaceArea = Desk.GetSurfaceArea();
            surfaceArea -= 1000;
            if (surfaceArea <= 0)
            {
                return 0;
            }
            return surfaceArea * 1;
            
        }
        public decimal GetTotal()
        {
             decimal total = 0;

            //1. get base cost
            total += Desk.BaseCost;
            //2. get surface area
            total += GetSurfaceCost();
            //3. number of drawers
            total += GetDrawerCost();
            //4. get surface material
            total += Desk.SurfaceMaterial.Cost;
            //5. rush order days
            total += RushOrder.GetCost(Desk);

            FinalQuote = total;
            return total;

        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", CustomerName, Desk.Width,
                Desk.Depth, Desk.SurfaceMaterial.Name,Desk.SurfaceMaterial.Cost,
                Desk.NumberOfDrawers, RushOrder.Name,RushOrder.LowCost,RushOrder.MediumCost,RushOrder.HighCost, Date);
            
        }

        //base cost, cost of material, drawer cost, delivery cost, surfacematerial cost, 
        //create final Quote method
    }

  
    //public string CustomerName
    class WriteDemo

    {
      
        public static void WriteToText(DeskQuote deskQuote)
        {

            string path = "C:\\Users\\lisac\\Documents\\quotes.txt";

            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(deskQuote.ToString());
            }
            
        }
       //contstants 
    }
}
