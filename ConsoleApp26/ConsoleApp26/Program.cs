using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {

        public static void level2(string file1, string id)
        {
           
            //newbies 
            int counter = 0;
            string line;
            int length = file1.Length;
            string[] inputlines = File.ReadAllLines(file1);
            string result = string.Empty;
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(file1);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(id))
                {
                    line = null;
                    var text = line;
                    result = text;

                    Console.WriteLine("{0}\n{1})", inputlines[counter], inputlines[counter + 1]);
                }

                else
                    counter++;

                
            }

            if (result == (""))
            {
                Console.WriteLine("Error sequence {0} not found", id);

            }


            file.Close();
            
            // Suspend the screen.  
            System.Console.ReadLine();

        }



        static void Main(string[] args)
        {
            level2(args[0], args[1]);

        }
    }
}

