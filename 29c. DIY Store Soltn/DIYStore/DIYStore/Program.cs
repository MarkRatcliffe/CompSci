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
            const double requiredSpend = 20.00;          // spend required on decorating
            const double gardeningDiscount = 0.1;        // associated discount on gardening

            String[,] purchases = new String[11,3];

            public void PrintReceipt(String[,] purchases)
            {
                // first we calculate total decorating spend
                double decoratingSpend = 0.0;
                for (int i = 0; i < purchases.GetLength(0); i++)
                {
                    if (purchases[i, 1] == "Decorating")
                    {
                        Console.WriteLine(purchases[i, 2]);
                        decoratingSpend = decoratingSpend + Convert.ToDouble(purchases[i, 2]);
                    }
                }

                // Now lets total up the purchases applying discounts where decoratingSpend > requiredSpend
                double totalCost = 0.0;
                double discount = 0.0;
                for (int i = 0; i < purchases.GetLength(0); i++)
                {

                    Console.WriteLine("{0} £{1:0.00}", purchases[i, 0], purchases[i, 2]);
                    totalCost = totalCost + Convert.ToDouble(purchases[i, 2]);
                    if ((purchases[i, 1] == "Gardening") && (decoratingSpend >= requiredSpend))
                    {
                        discount = Convert.ToDouble(purchases[i, 2]) * gardeningDiscount;
                        Console.WriteLine("-£{0:0.00} discount", discount);
                        totalCost = totalCost - discount;
                    };

                }
                Console.WriteLine("---------");
                Console.WriteLine("TOTAL : £{0:0.00}", totalCost);
                Console.ReadLine();
            }

            public String[,] SetUpPurchases()
            {
                String[,] myPurchases = new String[,]
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
                return myPurchases;
            }


            public static void Main(string[] args)
            {
                DIY myDIY = new DIY();

                myDIY.PrintReceipt(myDIY.SetUpPurchases());

            }
        }
    }
}
