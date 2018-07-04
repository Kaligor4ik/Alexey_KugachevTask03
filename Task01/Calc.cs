using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Calc
    {
        public static double CalcAverageLength(string[] arr)
        {
            int[] lengthArr = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                lengthArr[i] = arr[i].Length;
            }
            return Math.Round(lengthArr.Average(), 2);
        }
    }
}
