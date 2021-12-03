using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class MilesPerHourTable
    {
      
        public static void Main()
        {
            string rows;
            int row;
            int quit = 0;
            int mph = 5;
            double kph;

            while (quit==0) {
                Console.Write("Enter row count or quit(q): ");
                rows = Console.ReadLine();
                if (rows == "q")
                {
                    quit = 1;


                }

                else
                {

                    row = Convert.ToInt32(rows);
                    Console.WriteLine("MPH\tKPH");


                    for (int i = 0; i < row; i++)
                    {
                        mph = mph + 10;
                        kph = mph / 0.62137;
                        Console.WriteLine("{0}\t{1:0.00}", mph, kph);


                    }
                }

            }
        }
    }
}
