using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ST10085640_ICE_TASK1
{
    class Program
    {
        public static ArrayList items = new ArrayList();
        public static List<double> prices = new List<double>();

        static void Main(string[] args)
        {
            UserInput();
            CartClass.CalcTOT(prices);
            ItemClass.CalcVAT(prices);
        }
        public static void UserInput()
        {
            Console.WriteLine("WELCOME TO TAKE 5. \nEnter 'y' to continue (NB: VAT applies only to 5 items! Type 'exit' once you are done.)");
            var input = Console.ReadLine();
            try
            {
                while (input.Equals("y"))
                {
                    Console.Write("Enter the product name >> ");
                    string item = Console.ReadLine();
                    items.Add(item);
                    if (item.Equals("exit"))
                    {
                        items.Remove(item);
                        break;
                    }
                    Console.Write("Enter " + item + " price >> ");
                    double price = double.Parse(Console.ReadLine());
                    prices.Add(price);
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine(items[i] + " R " + prices[i]);
                }
                Console.WriteLine("----------------------------");

                if (items.Count != 5)
                {
                    Console.WriteLine();
                    throw new Exception("VAT only applies to exactly 5 items!!\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
