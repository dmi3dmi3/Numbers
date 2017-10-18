using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla2.Classes
{
    static class Units
    {
        static public WordIfno Black(string s)
        {
            WordIfno.ways way = WordIfno.ways.Black;
            switch (s)
            {
                case "ein":
                    return new WordIfno(1, way);
                case "eins":
                    return new WordIfno(1, true, way);
                case "zwei":
                    return new WordIfno(2, way);
                case "drei":
                    return new WordIfno(3, way);
                case "vier":
                    return new WordIfno(4, way);
                case "funf":
                    return new WordIfno(5, way);
                case "sech":
                    return new WordIfno(6, way);
                case "sechs":
                    return new WordIfno(6, true, way);
                case "sieb":
                    return new WordIfno(7, way);
                case "sieben":
                    return new WordIfno(7, true, way);
                case "acht":
                    return new WordIfno(8, way);
                case "neun":
                    return new WordIfno(9, way);
                default:
                    return new WordIfno();
            }
        }

        static public WordIfno Grey(string s)
        {
            if (s == "hundert")
                return new WordIfno(100, WordIfno.ways.Grey);
            return new WordIfno();
        }

        static public WordIfno Yellow(string s)
        {
            WordIfno.ways way = WordIfno.ways.Yellow;
            switch (s)
            {
                case "zwanzig":
                    return new WordIfno(20, way);
                case "dreibig":             
                    return new WordIfno(30, way);
                case "vierzig":             
                    return new WordIfno(40, way);
                case "funfzig":             
                    return new WordIfno(50, way);
                case "sechzig":             
                    return new WordIfno(60, way);
                case "siebzig":             
                    return new WordIfno(70, way);
                case "achtzig":             
                    return new WordIfno(80, way);
                case "neunzig":             
                    return new WordIfno(90, way);
                default:
                    return new WordIfno();
            }
        }

        static public WordIfno Orange(string s)
        {
            WordIfno.ways way = WordIfno.ways.Orange;
            switch (s)
            {
                case "zehn":
                    return new WordIfno(10, way);
                case "elf":
                    return new WordIfno(11, way);
                case "zwolf":
                    return new WordIfno(12, way);
                case "dreizehn":
                    return new WordIfno(13, way);
                case "vierzehn":
                    return new WordIfno(14, way);
                case "funfzehn":
                    return new WordIfno(15, way);
                case "sechzehn":
                    return new WordIfno(16, way);
                case "siebzehn":
                    return new WordIfno(17, way);
                case "achtzehn":
                    return new WordIfno(18, way);
                case "neunzehn":
                    return new WordIfno(19, way);
                default:
                    return new WordIfno();
            }
        }

        static public WordIfno Green(string s)
        {
            if (s == "und")
                return new WordIfno(0, WordIfno.ways.Green);
            return new WordIfno();
        }

        static public WordIfno Check(string s)
        {
            if (Black(s).Res >= 0) return Black(s);
            if (Grey(s).Res >= 0) return Grey(s);
            if (Yellow(s).Res >= 0) return Yellow(s);
            if (Orange(s).Res >= 0) return Orange(s);
            if (Green(s).Res >= 0) return Green(s);
            return new WordIfno();
        }
    }
}
