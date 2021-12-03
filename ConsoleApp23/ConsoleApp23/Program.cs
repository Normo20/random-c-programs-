using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sequence
{

    public static string[] Kmers(int k,  string[] dna )
    {
       int length = dna.Length;
        int n = k;
        string[] kmers = dna;

        for (int i =0; i<length; i++)
        {
           //string split kmers[i];


        }



        //split strings up into 1's
        // concatinate all strings into 1 string and return it 

        return kmers;
    }


    public static void ReverseComplement(string dna)
    {
        string array = dna;
        char[] charArray = array.ToCharArray();
        int length = array.Length;
        for (int i = 0; i < length; i++) {

            string reverse[] = charArray[i].Replace('A', 'T').Replace('T', 'A').Replace('G', 'C').Replace('C', 'G');

        }
            
            Array.Reverse(reverse);
        string finalreverse = new string(reverse);

        Console.WriteLine("{0}", finalreverse);


        // use the replace function to replace chars with their reverses 

        //confused as to what to return
        
    }


    public static bool Dyad (string dna, int min )
    {
        //check if starting chars of the string upto n are equal to the ending chars of the same length.
        
        
        //return true or false if they are/aren't



        return true;
    }


    static void Main(string[] args)
    {
        string dna = "AAGCT";
        ReverseComplement(dna);
    }
}
















