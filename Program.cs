using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Tip Calculator!");
                Console.WriteLine("How much is your bill?");
                decimal billAmount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("How much would like to tip?\n(enter corresponding number)\n");
                Console.WriteLine("1: 10 %");
                Console.WriteLine("2: 15 %");
                Console.WriteLine("3: 20 %");
                Console.WriteLine("4: Custom");

                string tipChoice = Console.ReadLine();

                decimal tipAmount;
                decimal totalBill;

                if (tipChoice == "1")
                {
                    tipAmount = billAmount * 0.10m;
                    totalBill = tipAmount + billAmount;
                    string tip = tipAmount.ToString("C2");
                    string bill = totalBill.ToString("C2");
                    Console.WriteLine("A 10 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                }

                else if (tipChoice == "2")
                {
                    tipAmount = billAmount * 0.15m;
                    totalBill = tipAmount + billAmount;
                    string tip = tipAmount.ToString("C2");
                    string bill = totalBill.ToString("C2");
                    Console.WriteLine("A 15 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                }

                else if (tipChoice == "3")
                {
                    tipAmount = billAmount * 0.20m;
                    totalBill = tipAmount + billAmount;
                    string tip = tipAmount.ToString("C2");
                    string bill = totalBill.ToString("C2");
                    Console.WriteLine("A 20 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                }

                else if (tipChoice == "4")
                {
                    Console.WriteLine("\n Enter your custom tip percentage:\n(like 0.23 for 23 percent)");
                    decimal customTip = decimal.Parse(Console.ReadLine());
                    tipAmount = billAmount * customTip;
                    totalBill = tipAmount + billAmount;
                    string tip = tipAmount.ToString("C2");
                    string bill = totalBill.ToString("C2");
                    Console.WriteLine("Your tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                }
        }
    }
}
