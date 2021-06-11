using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter8_PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[12, 5];
            int[] array1D = new int[60];
            Random element = new Random();

            for (int i = 0; i < array2D.GetLength(0); i++) 
            {
                for (int j = 0; j < array2D.GetLength(1); j++) 
                {
                    array2D[i,j]=element.Next(1, 100);
                }
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {

                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Write(array2D[i, j]+"\t");
                }
                Write("\n");
            }



            int count = 0;
            for (int i = 0; i < array2D.GetLength(0); i++)  
            {

                for (int j = 0; j < array2D.GetLength(1); j++)  
                {
                    array1D[count++] = array2D[i, j];
                }
             
            }



            WriteLine();
            for (int i = 0; i < array1D.Length; i++) 
            {
                
                Write("{0,-8}",array1D[i]);

            }
            ReadKey();


        }
    }
}
