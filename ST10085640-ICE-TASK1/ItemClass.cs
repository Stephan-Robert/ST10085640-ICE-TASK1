using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ST10085640_ICE_TASK1
{
    class ItemClass
    {
        public static double CalcVAT(List<double> prices)
        {
            double VAT = 0;
            if (prices.Count == 5)
            {
                Console.WriteLine("Do you wish to see the VAT on each specific item? 'y' for yes, 'n' for no.");
                string inp = Console.ReadLine();
                if (inp.Equals("y"))
                {
                    for (int i = 0; i < prices.Count; i++)
                    {
                        VAT = prices[i] * 14 / 100;
                        Console.WriteLine("R " + prices[i] + " included VAT: R " + VAT);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            return VAT;
        }
    }

    
}
