using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    public class FindPlate
    {
        public List<StringBuilder> Plate = new List<StringBuilder>();
        
        public FindPlate(string[] plate)
        {
            string pattern1 = @"[A-Z]{2}\d{6}";
            for (int i = 0; i < plate.Length; i++)
            {
                if (Regex.IsMatch(plate[i].Split('|')[1], pattern1))
                {
                    Plate.Add(new StringBuilder(plate[i]));
                }
            }
        }

        public List<StringBuilder> SortByCountry()
        {
            for(int i = 0; i < Plate.Count; i++)
            {
                int kol = 0;
                for(int j = 0; j < Plate.Count; j++)
                {
                    if (Regex.Replace(Plate[i].ToString().Split('|')[1], @"\D", "") == Regex.Replace(Plate[j].ToString().Split('|')[1], @"\D", ""))
                    {
                        kol++;
                    }
                }
                if(kol <= 1)
                {
                    Plate.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine();
            for(int i = 0; i < Plate.Count; i++)
            {
                for(int j = 0; j < Plate.Count; j++)
                {
                    if (StringСomparison(Regex.Replace(Plate[i].ToString().Split('|')[1], @"\d", ""), Regex.Replace(Plate[j].ToString().Split('|')[1], @"\d", "")))
                    {
                        var buf = Plate[i];
                        Plate[i] = Plate[j];
                        Plate[j] = buf;
                    }
                }
            }
            return Plate;
        }

        public bool StringСomparison(string str1, string str2)
        {
            int n = str1.Length > str2.Length ? (str1.Length) : (str2.Length);
            for( int i = 0; i < n; i++)
            {
                if (str1[i] < str2[i])
                {
                    return true;
                }
                else if (str1[i] > str2[i])
                {
                    return false;
                }
            }
            return false;
        }
    }
}
