using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._5
{
    public class arraycalc
    {
        public static double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        public static double summa = 0;
        public static double ave = 0;
        public static double min = 0;
        public static double max = 0;
        public static void Plus()
        {
            foreach (var num in arraycalc.array)
            {
                summa += num;       
            }
            
            
        }
        public static void Ave()
        {
            ave = summa / arraycalc.array.Length;
        }

        public static void Min()
        {
            min = array.Min();
        }
        public static void Max()
        {
            max = array.Max();
        }
        
    }
}
