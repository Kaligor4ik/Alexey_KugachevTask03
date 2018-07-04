using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Первая строка, которая пришла мне в голову!";
            Console.WriteLine(str);
            string str2 = "Вторая строка не пришла";
            Console.WriteLine(str2);
            string str3 = CharsDuplicator.ifPresentDuplicate(str, str2);
            Console.WriteLine(str3);
            Console.ReadKey();
        }
    }
}
