using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3] { "Объект сравнения\\культура", "ru", "en" };
            jaggedArray[1] = new string[3] { "Формат отображения даты и времени", "ru", "en" };
            jaggedArray[2] = new string[2] { "Формат отображения числовых данных ", "ru" };

            string[][] jaggedArray2 = new string[3][];
            jaggedArray2[0] = new string[3] { "Объект сравнения\\культура", "ru", "invariant" };
            jaggedArray2[1] = new string[2] { "Формат отображения даты и времени", "ru" };
            jaggedArray2[2] = new string[2] { "Формат отображения числовых данных ", "ru" };

            Console.WriteLine("Номер таблицы: \n1)ru+en\n2)ru+inv");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "2":
                    TableBuilder.BuildByJaggedArr(jaggedArray2);
                    break;
                default:
                    TableBuilder.BuildByJaggedArr(jaggedArray);
                    break;
            }
            Console.ReadKey();
        }
    }
}
