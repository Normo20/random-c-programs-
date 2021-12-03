using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixLibrary
{

    public static string MatrixToString(int[,] matrix )
    {
        var result = string.Empty;
        var maxI = matrix.GetLength(0);
        var maxJ = matrix.GetLength(1);
        for (var i = 0; i < maxI; i++)
        {
      
            for (var j = 0; j < maxJ; j++)
            {

                result += string.Format("{0,-4}", matrix[i, j]);
                
              
            }

            
        }
        

        return result ;
    }



    public static int[,] MatrixMultiply(int[,] A, int[,] B)
    {
        
        

        int m = A.GetUpperBound(0) - A.GetLowerBound(0) + 1;
        int n = A.GetUpperBound(1) - A.GetLowerBound(1) + 1;
        int q = n; //rows in b which need to be same as columns in a
        int j, i;
        int[,] c = new int[m, q];
        for ( i = 0; i < m; i++)
        {   
            for ( j = 0; j < q; j++)
            {
                c[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    c[i, j] += A[i, k] * B[k, j];
                }

                }

           
            }

        return c;
    }


   
}    

