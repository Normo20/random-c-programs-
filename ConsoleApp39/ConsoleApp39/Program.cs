using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("what's your height?");
            string Hight = Console.ReadLine();
            int Hight1 = Int32.Parse(Hight);
            Console.WriteLine("What's your weight?");
            String weight = Console.ReadLine();
            int weight1 = Int32.Parse(weight);
            int bmi = (weight1 / ((Hight1 ^ 2))/1000);
            int Bmi = bmi * 10;
            Console.WriteLine("Your bmi is {0}", Bmi);



        }
    }
}
