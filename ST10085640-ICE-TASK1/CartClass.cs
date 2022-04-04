using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST10085640_ICE_TASK1
{
    class CartClass
    {
        public static double CalcTOT(List<double> prices)
        {
            double total = prices.Sum();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total: R " + total);

            if(prices.Count == 5)
            {
                double VAT = total * 14 / 100;
                double grnTOT = total + VAT;
                Console.WriteLine("+ VAT: R " + VAT);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Grand Total: R " + grnTOT
                                + "\n----------------------------");
            }
            return total;
        }
        
    }
}
