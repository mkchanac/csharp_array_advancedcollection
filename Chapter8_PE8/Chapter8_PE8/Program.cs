using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter8_PE8
{
    class Program
    {
        static void Main()
        {
            string inValue = "";
            Write("Enter the english phrase: ");
            inValue = ReadLine();
            string[] sentence = new string[1000];
            sentence = inValue.Split(' ');
            int count = 0;

            for (int i = 0; i < sentence.Length; i++) 
            {
                if (sentence[i] != null) 
                {
                    count++;
                }
            }

            string[] sentence_1 = new string[count];
            sentence_1 = sentence.ToArray();
            string[] str = new string[count]; 

            for (int i = 0; i < count; i++)
            {
                str[i] = sentence_1[i].Substring(1, sentence_1[i].Length-1) + sentence_1[i].Substring(0, 1) + "ay";
            }

            Write("English Phrase: ");
            foreach (string x in sentence_1)
            { Write(x + " "); }

            WriteLine();
            Write("Pig Phrase: ");
            foreach (string x in str)
            { Write(x+" "); }
            ReadKey();



        }
    }
}
