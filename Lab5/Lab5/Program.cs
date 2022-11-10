using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] plates = { "ДТП 1|KR228133", "ДТП 2|BY228133", "ДТП 3|RU148832", "ДТП 4|UK456712", "ДТП 5|BE228322", "ДТП 6|US228322", "ДТП 7|BL228322", "ДТП 8|AR783401", "ДТП 9|PL567324" , "ДТП 10|AS228322" };
            Console.WriteLine("Список всех номеров: \n");
            foreach (string plate in plates)
            {
                Console.WriteLine(plate);
            }
            FindPlate findPlate = new FindPlate(plates);
            List<StringBuilder> resault = findPlate.SortByCountry();

            Console.WriteLine("Список повторяющихся номеров отсортированных в алфавитном порядке: \n");
            foreach (StringBuilder s in resault)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}