using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7_2
{
    class AreaCodeApp
    {
        static void Main(string[] args)
        {
            int[] FlorAreaCode = { 305, 321, 352, 386, 407, 561, 727, 754, 772, 786, 813, 850, 863, 904, 941, 954 };
            AreaCode Florida = new AreaCode("Florida",FlorAreaCode);
            Write(Florida);
            Florida.TestNum = 399;
            Write("\n\n"+Florida.DisplayTestResult());
            Florida.TestNum = 850;
            Write("\n\n" + Florida.DisplayTestResult());

            int[] CaliAreaCode = { 209, 213, 310, 323, 408, 415, 510, 530, 559, 562, 619, 626, 650, 661, 707, 714, 760, 805, 818, 831, 858, 909, 916, 925, 949 };
            AreaCode California = new AreaCode("California", CaliAreaCode);
            Write("\n\n" + California);
            California.TestNum = 559;
            Write("\n\n" + California.DisplayTestResult());
            California.TestNum = 560;
            Write("\n\n" + California.DisplayTestResult());

            ReadKey();



        }
    }
}
