using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Year
    {
        public static bool IsLeap(int year)
        {
            bool isLeap = false;

            if (year % 4 == 0 && year % 100 != 0)
            {
                isLeap = true;
            }

            if (year % 100 == 0 && year % 400 == 0)
            {
                isLeap = true;
            }
            
            return isLeap;
        }

    }

