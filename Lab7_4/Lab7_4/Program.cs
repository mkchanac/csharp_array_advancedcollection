using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7_4
{
    class Program
    {
        static void Main()
        {
            string moreSales;
            
            string[] salesRegistry = { "Jamaal Avery", "Amanda Davidson", "Bob Murphey", "Jim Saylor", "Choo Wang", "Lonna Young" };
            string[] salesProduct = { "Tablets", "Phones", "Watches" };
            double[,] salesSummary = new double[6, 3];

            do
            {
                GetSalesInformation(salesRegistry, salesProduct, ref salesSummary);

                Write("\nAre there more sales? <y or n> ");
                moreSales = ReadLine();

            } 
            while (moreSales == "y");

            DisplaySalesSummary(salesRegistry, salesProduct, salesSummary);


            ReadKey();

        }

        public static void GetSalesInformation(string[] sName, string[] sPro, ref double[,] sales)  
        {
            int row, column;
            Write("\nSales Registry");
            for (int i = 0; i < sName.Length; i++) 
            {
                Write("\n{0}. {1}", i + 1, sName[i]);
            }
            Write("\n\nSales are for which salesman? ");
            row = int.Parse(ReadLine()) - 1;

            Write("\nProducts");
            for (int i = 0; i < sPro.Length; i++)
            {
                Write("\n{0}. {1}", i + 1, sPro[i]);
            }
            Write("\n\nSales are for which product? ");
            column = int.Parse(ReadLine()) - 1;

            Write("\nWhat was the sales amount? ");
            sales[row,column] = double.Parse(ReadLine());

        }
        public static void DisplaySalesSummary(string[] sName, string[] sPro, double[,] sales) 
        {

            Write("\n\t\tSales Summary\n");
            Write("{0,-25}", "\nSalesman Name");
            for (int i = 0; i < sPro.Length; i++)
            {
                Write("{0,-15}",sPro[i]);
            }
            WriteLine();

            for (int i = 0; i < sales.GetLength(0); i++) 
            {
                Write("\n{0,-25}",sName[i]);
                for (int j = 0; j < sales.GetLength(1); j++) 
                {
                    Write("{0,-15:N2}",sales[i,j]);
                }
            
            }


        }



    }
}
