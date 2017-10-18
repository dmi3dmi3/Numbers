using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla2.Classes
{
    class Translator
    {
        public string str_chislo;
        public string[] chislo;

        public Translator(string s)
        {
            s = s.ToLower();
            s = DelExtraSpaces(s);
            chislo = s.Split(' ');
            str_chislo = "";     
            foreach (string item in chislo)
                str_chislo += item + " ";
            str_chislo = str_chislo.Remove(str_chislo.Length - 1);
        }

        public string DelExtraSpaces(string s)
        {
            s = s.Trim();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    if (s[i + 1] == ' ')
                    {
                        s = s.Remove(i + 1, 1);
                        i--;
                    }
            }
            return s;
        }
    }
}
