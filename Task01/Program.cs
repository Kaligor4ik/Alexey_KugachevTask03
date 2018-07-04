using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Первая строка, которая пришла мне в голову! Вторая не пришла.";
            Console.WriteLine(str);
            string[] arr = SentenceParser.Parse(str);
            Console.WriteLine("Распаршено: ");
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Средний размер слова: {0}", Calc.CalcAverageLength(arr));
            Console.ReadKey();
        }
    }
}
