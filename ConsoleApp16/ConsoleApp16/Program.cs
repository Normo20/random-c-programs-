using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear_Search
{
    class Program
    {

        //main
        static void Main(string[] args)
        {

            const string Start_Message = "\n\tWelcome to Linear Search Demonstration\n"
                                        + "\n The array contains the following 9 words:\n\n";

            string[] words = {"the", "quick", "brown", "fox",
                              "jumps", "over", "the", "lazy", "dog"};

 
            OutputMessage(Start_Message);
            DisplayArray(words);

         

        } //end Main

       


        
        /// Displays the elements of the array "words"
        /// </summary>
        /// <param name="words">array to be displayed</param>
        static void DisplayArray(string[] words)
        {

            foreach (string element in words)
            {
                OutputMessage("\t" + element + "\n");
            }
            Console.WriteLine();

        }//end DisplayArray

        /// <summary>
        /// Displays the outcome of the linear search
        /// </summary>
        /// <param name="word"></param>
     

        /// <summary>
        /// Outputs the string "s"
        /// </summary>
        /// <param name="s">String to be output</param>
        static void OutputMessage(string s)
        {

            Console.Write(s);
        }// end OutPutMessage

       

    }//end class
}//end namespace
