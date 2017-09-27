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

        public Translator(){}
       
        public void Set(string s)
        {
            s = s.Replace(" ", "");
            chislo = s.ToLower();
            tmp_chislo = chislo;
        }

        public string TakeBegining()
        {
            s_chislo = Tools.Remove(tmp_chislo, 3);
            return s_chislo;
        }

        public string Cut(int a)
        {
            tmp_chislo = Tools.TakeEnd(tmp_chislo, a);
            return tmp_chislo;
        }
    }
}
