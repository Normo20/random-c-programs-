using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer3;
            int v1 = 1, v2 = 19;
            answer3 = v1 % v2++;
            Console.WriteLine("Expression 3 - {0}", answer3);
        }
    }
}
