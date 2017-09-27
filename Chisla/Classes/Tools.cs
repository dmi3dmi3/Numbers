using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla.Classes
{
    static class Tools
    {
        public static string TakePart(string s1, int a, int b)
        {
            string s2 = "";
            for (int i = a; i <= b; i++)
            {
                s2 += s1[i];
            }
            return s2;
        }

        public static string Remove(string s, int a)
        { 
            while (a >= s.Count())
            {
                s += " ";
            }
            return s.Remove(a);
        }

        public static string TakeEnd(string s, int a)
        {
            string s2 = "";
            if (a >= s.Count())
                return "";
            for (int i = a; i < s.Count(); i++)
            {
                s2 += s[i];
            }
            return s2;
        }
    }
}
