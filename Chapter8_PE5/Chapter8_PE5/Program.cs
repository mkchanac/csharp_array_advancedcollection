using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter8_PE5
{
    class Program
    {
        static void Main()
        {
            string moreName = "";
            int count = 0;
            string[] nameSet = new string[1000];
            do
            {

                Write("Enter your name <first-name space last-name>: ");
                string[] name = new string[3];
                string inValue;
                inValue = ReadLine();
                name = inValue.Split(' ');

                if (name.Length < 2)
                    nameSet[count] = name[0];
                else 
                if (name.Length <3)
                    nameSet[count] = name[1] + ", " + name[0];
                else
                    nameSet[count] = name[2] + ", " + name[0] + " " + name[1];

                count++;
                Write("Do you want to enter more name? <Y or N> ");
                moreName = ReadLine();
            }
            while (moreName == "Y" || moreName == "y");

            Clear();
            Array.Sort(nameSet);

            foreach (string x in nameSet) 
            { 
                if(x!=null) WriteLine(x); 
            }
            ReadKey();

        }
    }
}
