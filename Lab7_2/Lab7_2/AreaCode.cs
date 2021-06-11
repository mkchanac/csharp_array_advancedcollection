using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab7_2
{
    class AreaCode
    {
        private int[] area_Code;
        private int testNum;
        private string stateName;

        public AreaCode() 
        {
        }

        public AreaCode(string sName, int[] aCode) 
        {
            stateName = sName;
            area_Code = aCode;
        }

        public int[] Area_Code
        {
            get 
            {
                return area_Code;
            }
            set
            {
                area_Code = value;
            }
        }

        public int TestNum
        {
            get
            {
                return testNum;
            }
            set
            {
                testNum = value;
            }
        }

        public string StateName
        {
            get { return stateName; }
            set
            {
                stateName = value;
            }
        }

        public override string ToString()
        {
            string areaCodeString="";

            for (int i = 0; i < area_Code.Length; i++) 
            {
                areaCodeString += "(" + area_Code[i] + ")" + "   ";
            }
            
            return "List of " + stateName + " Area Codes\n" + "\n" + areaCodeString;
        }

        public bool TestAreaCode()
        {
            bool testResult = false;
            int index = Array.BinarySearch(area_Code, testNum);
            if (index > 0)
                testResult = true;
            return testResult;
        }

        public string DisplayTestResult()
        {
            return "Area Code " + testNum + " in " + stateName + "?" + " " + TestAreaCode().ToString();
        }
    }
}
