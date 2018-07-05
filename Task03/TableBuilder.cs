using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class TableBuilder
    {
        private const int defaultLength = 40;
        public static void BuildBy2DArr<T>(T[,] arr)
        {
            int maxArrLength = arr.GetLength(0);
            int maxElementLength = GetMaxElement(arr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sb.AppendFormat("{0}\n", new String('-', maxArrLength * maxElementLength + maxArrLength));
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    try
                    {
                        sb.AppendFormat("|{0," + maxElementLength + "}|", IfOutCut(arr[i, j]));
                    }
                    catch (IndexOutOfRangeException)
                    {
                        sb.AppendFormat("|{0," + maxElementLength + "}|", "-");
                    }
                }
                sb.AppendFormat("\n{0}\n", new String('-', maxArrLength * maxElementLength + maxArrLength));
            }
            Console.Write(sb);
        }

        public static void BuildByJaggedArr<T>(T[][] arr)
        {
            int maxArrLength = GetMaxRange(arr);
            int maxElementLength = GetMaxElement(arr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sb.AppendFormat("{0}\n", new String('-', maxArrLength * maxElementLength + maxArrLength * 2));
                for (int j = 0; j < maxArrLength; j++)
                {
                    try
                    {
                        sb.AppendFormat("|{0," + maxElementLength + "}|", IfOutCut(arr[i][j]));
                    }
                    catch (IndexOutOfRangeException)
                    {
                        sb.AppendFormat("|{0," + maxElementLength + "}|", "-");
                    }
                }
                sb.AppendFormat("\n{0}\n", new String('-', maxArrLength * maxElementLength + maxArrLength * 2));
            }
            Console.Write(sb);
        }

        public static int GetMaxRange<T>(T[][] arr)
        {
            int maxLength = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i].Length > maxLength)
                {
                    maxLength = arr[i].Length;
                }
            }
            return maxLength;
        }

        public static int GetMaxElement<T>(T[][] arr)
        {
            int maxLength = 0;
            foreach (T[] t in arr)
                foreach (T k in t)
                    if (k.ToString().Length > maxLength)
                    {
                        maxLength = k.ToString().Length;
                    }
            return maxLength > defaultLength ? defaultLength : maxLength;
        }

        public static int GetMaxElement<T>(T[,] arr)
        {
            int maxLength = 0;
            foreach (T t in arr)
                if (t.ToString().Length > maxLength)
                {
                    maxLength = t.ToString().Length;
                }
            return maxLength;
        }

        public static string IfOutCut<T>(T t)
        {
            return IfOutCut(t, defaultLength);
        }

        public static string IfOutCut<T>(T t, int lineLength)
        {
            string str = t.ToString();
            if (str.Length >= lineLength)
            {
                return str.Substring(0, defaultLength - 3) + "...";
            }
            else
            {
                return str;
            }
        }
    }
}
