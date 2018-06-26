using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaDeskWeb.App_Code
{
    public struct Desk
    {
        public int width; // min 24, max 96
        public int depth; // min 12, max 48
        public int numDrawers; // 0 - 7
        public string material; // laminate, oak, rosewood, veneer, pine
    }

    public class DeskQuote
    {
        public Desk desk;
        public String customerName;
        public DateTime date;
        public string rushOption; // three, five, seven, fourteen

        public DeskQuote()
        {
            desk.width = 0;
            desk.depth = 0;
            desk.numDrawers = 0;
            desk.material = "";
            customerName = "";
            date = DateTime.Now;
            rushOption = "";
        }

        public int getSurfaceArea()
        {
            return desk.width * desk.depth;
        }

        public int calcRushOrderCost()
        {
            int surfaceArea = getSurfaceArea();

            switch (rushOption)
            {
                case "three":
                    if (surfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (surfaceArea < 2001)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }
                case "five":
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea < 2001)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }
                case "seven":
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea < 2001)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }
                case "fourteen":
                default:
                    return 0;
            }
        }

        public int calcTotal()
        {
            // base price: 200
            int total = 200;

            // surface area cost
            int surfaceArea = getSurfaceArea();
            if (surfaceArea > 1000)
            {
                total += (surfaceArea - 1000);
            }

            // drawers cost
            total += desk.numDrawers * 50;

            // material cost
            switch (desk.material)
            {
                case "laminate":
                    total += 100;
                    break;
                case "oak":
                    total += 200;
                    break;
                case "rosewood":
                    total += 300;
                    break;
                case "veneer":
                    total += 125;
                    break;
                case "pine":
                    total += 50;
                    break;
                default:
                    break;
            }

            total += calcRushOrderCost();

            return total;
        }
    }
}