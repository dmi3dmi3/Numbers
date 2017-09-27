using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla.Classes
{
    class Translator
    {
        public string chislo;//Изначальное слово
        public string tmp_chislo;//Остаток слова
        public string s_chislo;//Первые 3 буквы остатка
        public string output = "";
        public int errLong = 0;
        public int result;
        public bool endFlag;

        public Translator(){}
       
        public void Set(string s)
        {
            s = s.Replace(" ", "");
            chislo = s.ToLower();
            tmp_chislo = chislo;
        }

        public string TakeBegining()
        {
            if (tmp_chislo.Count() >= 3)
                s_chislo = tmp_chislo.Remove(3);
            else if (tmp_chislo.Count() == 2)
                s_chislo = tmp_chislo.Remove(2);
            else if (tmp_chislo.Count() == 1)
                s_chislo = tmp_chislo.Remove(1);
            else s_chislo = "";
            return s_chislo;
        }

    }
}
