using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    public class StringOrder
    {
        enum Order { Precedes = -1, Equals = 0, Follows = 1 };

        public static void Main()
        {
            string name_A;
            string name_B;
            Console.WriteLine("What is name A?");
            name_A = Console.ReadLine();
            Console.WriteLine("What is name B?");
            name_B = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}",name_A,(Order)name_A.CompareTo(name_B),name_B);
        }
    }
}