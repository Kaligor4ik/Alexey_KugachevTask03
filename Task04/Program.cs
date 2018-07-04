using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04

{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            VelocityMeter.Measure(p.AddString);
            VelocityMeter.Measure(p.AddSb);
            Console.ReadKey();
        }

        public void AddString()
        {
            string str = "";
            int N = 100000;
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }

        }

        public void AddSb()
        {
            StringBuilder sb = new StringBuilder();
            int N = 100000000;
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
        }
    }
}
