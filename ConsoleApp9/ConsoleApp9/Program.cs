using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

   

    class IncomeTax
    {
        public static void Main()
        {
            int income;
            int children;
            double total;
            bool success;
            bool success1;
            do
            {
                Console.Write("What is your total income: ");
                success = int.TryParse(Console.ReadLine(), out income);
                if (!success)
                {
                    Console.WriteLine("Enter your income as a whole-dollar figure.");
                }
                else if (income < 0)
                {
                    Console.WriteLine("Your income cannot be negative.");
                    success = false;
            }
            } while (!success);

            do
            {
                Console.Write("How many children do you have: ");
                success1 = int.TryParse(Console.ReadLine(), out children);
                if (!success1)
                {
                    Console.WriteLine("You must enter a valid number");
                }
                else if (children < 0)
                {
                    Console.WriteLine("You must enter a positive number.");
                    success1 = false;
                }
            } while (!success1);

            total = (income - 10000 - (2000 * children))*0.02;
            if(total<0) {
                Console.WriteLine("You owe no tax.");


            }
            else
            {
                Console.WriteLine("You owe a total of ${0:F} tax ", total);

            }


        }
    }





}

