using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYStore
{
    class Program
    {
        public class DIY
        {

            public static void Main(string[] args)
            {
                const double requiredSpend = 20.00;          // spend required on decorating
                const double gardeningDiscount = 0.1;        // associated discount on gardening

                String[,] purchases = new String[,]
                    { {"Matt Pink Paint", "Decorating", "6.99"},
                    {"Floral Wallpaper", "Decorating", "7.99"},
                    {"Magnolia Gloss Paint", "Decorating", "5.49"},
                    {"Weed Killer", "Gardening", "2.99"},
                    {"Picture Frame", "Decorating", "8.99"},
                    {"Plug Socket", "Electrics", "6.99"},
                    {"Doorbell", "Electrics", "15.99"},
                    {"Matt White Paint", "Decorating", "4.99"},
                    {"Tiles", "Decorating", "19.99"},
                    {"Grass Seed", "Gardening", "1.99"},
                    {"Lawn Mower", "Gardening", "129.99"},
                    };

                // first we calculate total decorating spend
                double decoratingSpend = 0.0;
                for (int i = 0; i < purchases.GetLength(0); i++)
                {
                    if (purchases[i, 1] == "Decorating")
                    {
                        decoratingSpend = decoratingSpend + Convert.ToDouble(purchases[i, 2]);
                    }
                }

                // Now lets total up the purchases applying discounts where decoratingSpend > requiredSpend
                double totalCost = 0.0;
                double discount = 0.0;

                Console.WriteLine("---------");
                Console.WriteLine("TOTAL : £{0:0.00}", totalCost);
                Console.ReadLine();
            }
        }
    }
}
