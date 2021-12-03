using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public abstract class Converter
    {
        /// <summary>
        /// This method returns a string indicating the unit this converter converts from
        /// </summary>
        /// <returns>String indicating the unit being converted from</returns>
        public abstract string From();

        /// <summary>
        /// This method returns a string indicating the unit this converter converts to. 
        /// </summary>
        /// <returns>String indicating the unit being converted to</returns>
        public abstract string To();

        /// <summary>
        /// Convert a value to another unit.
        /// </summary>
        /// <param name="value">Value to convert, in type indicated by 'From' method</param>
        /// <returns>Converted value, in type indicated by 'To' method</returns>
        public abstract float Convert(float value);
    }

    // Write your converter classes here
    // ...

    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int menuOption;

            List<Converter> converters = new List<Converter>();

            // Uncomment these to test out new classes as you implement them
            //converters.Add(new MetresToCentimetres());
            //converters.Add(new CelsiusToFahrenheit());
            //converters.Add(new MilesToKilometres());
            //converters.Add(new DegreesToRadians());

            while (running)
            {
                DisplayMenu(converters);
                menuOption = GetMenuSelection(converters.Count);

                if (menuOption == 0)    // if exit is selected, stop running
                {
                    running = false;
                }
                else
                {
                    Converter currentConverter = converters[menuOption - 1]; // minus one to get correct index
                    float fromValue = GetConversionFromValue(currentConverter);
                    float result = currentConverter.Convert(fromValue);
                    DisplayResult(currentConverter, result);
                }
            }
        }


        private static float GetConversionFromValue(Converter currentConverter)
        {
            bool inputValid;
            float fromValue;

            Console.WriteLine("Converting from {0} to {1}\n", currentConverter.From(), currentConverter.To());
            do
            {
                Console.Write("Enter input ({0}): ", currentConverter.From());


                inputValid = float.TryParse(Console.ReadLine(), out fromValue);
                if (!inputValid)
                {
                    Console.WriteLine("Invalid value.");
                }
            } while (!inputValid);

            return fromValue;
        }


        private static void DisplayResult(Converter currentConverter, float result)
        {
            Console.WriteLine("Result ({0}): {1}", currentConverter.To(), result);
        }


        private static int GetMenuSelection(int numOptions)
        {
            bool inputValid;
            int menuOption;

            do
            {
                Console.Write("Choose a converter (or type 0 to exit): ");
                inputValid = int.TryParse(Console.ReadLine(), out menuOption);
                if (!inputValid || menuOption < 0 || menuOption > numOptions)
                {
                    inputValid = false;
                    Console.WriteLine("Invalid option.");
                }
            } while (!inputValid);

            return menuOption;
        }


        private static void DisplayMenu(List<Converter> converters)
        {
            Console.WriteLine("\n\n  Conversion Menu");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            for (int i = 0; i < converters.Count; i++)
            {
                Console.WriteLine("{0}. {1} to {2}", i + 1, converters[i].From(), converters[i].To());
            }

            Console.WriteLine();
        }
    }
}
