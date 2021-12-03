using System;

namespace RandomArray
{
    public class RandomArrayNoDuplicates
    {
        static Random rng = new Random();
        
        /// <summary>
        /// Creates an array with each element a unique integer
        /// between 1 and 45 inclusively.
        /// </summary>
        /// <param name="size"> length of the returned array < 45
        /// </param>
        /// <returns>an array of length "size" and each element is
        /// a unique integer between 1 and 45 inclusive </returns>
        public static int[] ArrayWithNoDuplicates(int size)
        {
           
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                int randNum = rng.Next(1, 45);
                array [i] = randNum;
                Console.WriteLine("{0}", array[i]);
                

            }


            return array;
        }

      
    }



}
