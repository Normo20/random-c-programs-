using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            double interestRate = 0.02;
            double timesPerYear = 365;
            double years = 1;
            double final_ammount;
            double principal = 100;

            // (1 + r/n)
            double body = 1 + (interestRate / timesPerYear);

            // nt
            double exponent = timesPerYear * years;

            // P(1 + r/n)^nt
            final_ammount =principal * Math.Pow(body, exponent);

            Console.WriteLine("{0}", final_ammount);
        }
    }
}
