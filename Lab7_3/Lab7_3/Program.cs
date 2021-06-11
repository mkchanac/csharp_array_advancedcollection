using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string inValue;
            int number;
            int[] frequency = new int[11];
            do
            {
                Write("\nInput any number between 0 and 10 (-1 to stop): ");
                inValue = ReadLine();

                while (int.TryParse(inValue, out number) == false) 
                {
                    Write("\nInvalid data - re-enter number [0 to 10] (-1 to stop): ");
                    inValue = ReadLine();                
                }

                switch (number) 
                {
                    case -1:
                        break;
                    case 0:
                        frequency[0]++;
                        break;
                    case 1:
                        frequency[1]++;
                        break;
                    case 2:
                        frequency[2]++;
                        break;
                    case 3:
                        frequency[3]++;
                        break;
                    case 4:
                        frequency[4]++;
                        break;
                    case 5:
                        frequency[5]++;
                        break;
                    case 6:
                        frequency[6]++;
                        break;
                    case 7:
                        frequency[7]++;
                        break;
                    case 8:
                        frequency[8]++;
                        break;
                    case 9:
                        frequency[9]++;
                        break;
                    case 10:
                        frequency[10]++;
                        break;
                    default:
                        WriteLine("\nInvalid number");
                        break;
                }
                    
            }
            while (inValue != "-1");

            WriteLine("\nFrequency Distribution\n");

            for (int i = 0; i < frequency.Length; i++) 
            {
                string freq = new string('*', frequency[i]);
                WriteLine("| " + i + "\t" + freq);
                WriteLine();
            }

            ReadKey();




        }
    }
}
