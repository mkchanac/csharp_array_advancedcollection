using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter8_PE6
{
    class Program
    {
        static void Main()
        {
            int rowNum = 0;
            int colNum = 0;
            Random element = new Random();
            Write("Enter the number of row(s): ");
            rowNum = int.Parse(ReadLine());
            Write("Enter the number of column(s): ");
            colNum = int.Parse(ReadLine());

            int[,] array = new int[rowNum, colNum];

            for (int i = 0; i < array.GetLength(0); i++) 
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = element.Next(0, 100);
                }
            
            }
            WriteLine();
            WriteLine("The largest value in the array: {0}",array.Cast<int>().Max());
            WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write(array[i,j] + "\t");
                }
                WriteLine();
            }
            WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == array.Cast<int>().Max()) 
                    {
                        WriteLine("The largest value stored in {0} row and {1} column.", i, j);
                    
                    }
                }

            }


            ReadKey();

        }
    }
}
