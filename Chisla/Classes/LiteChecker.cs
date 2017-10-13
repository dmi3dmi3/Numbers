using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla.Classes
{
    static class LiteChecker
    {
        public enum Way
        {
            Black, Orange, Brown, Grey, Red, Yellow, Green, Blue, Error
        }
        // 1-9
        public static int Black(string s)
        {
            switch (s)
            {
                case "ein":
                    return 1;               
                case "zwe":
                    return 2;
                case "dre":
                    return 3;
                case "vie":
                    return 4;
                case "fun":
                    return 5;
                case "sec":
                    return 6;
                case "sie":
                    return 7;
                case "ach":
                    return 8;
                case "neu":
                    return 9;
                default:
                    return -1;
            }
        }

        //zehn
        public static int Orange(string s)
        {
            switch (s)
            {
                case "zeh":
                    return 10;
                default:
                    return -1;
            }
        }

        //11-12
        public static int Brown(string s)
        {
            switch (s)
            {
                case "elf":
                    return 11;
                case "zwo":
                    return 12;
                default:
                    return -1;
            }
        }

        //hundert
        public static int Grey(string s)
        {
            switch (s)
            {
                case "hun":
                    return 100;
                default:
                    return -1;
            }
        }

        //zig,big
        public static int Yellow(string s)
        {
            if (s=="zig" || s == "big")
                return 10;
            return -1;
        }

        //und
        public static int Green(string s)
        {
            switch (s)
            {
                case "und":
                    return 1;
                default:
                    return -1;
            }
        }

        //2-9
        public static int Blue(string s)
        {
            switch (s)
            {
                case "dre":
                    return 3;
                case "vie":
                    return 4;
                case "fun":
                    return 5;
                case "sec":
                    return 6;
                case "sie":
                    return 7;
                case "ach":
                    return 8;
                case "neu":
                    return 9;
                default:
                    return -1;
            }
        }

        public static int Red(string s)
        {
            if (s == "zwa")
                return 20;
            return -1;
        }

        public static Way Check(string s)
        {
            if (Black(s) > 0) return Way.Black;
            if (Orange(s) > 0) return Way.Orange;
            if (Brown(s) > 0) return Way.Brown;
            if (Grey(s) > 0) return Way.Grey;
            if (Yellow(s) > 0) return Way.Yellow;
            if (Green(s) > 0) return Way.Green;
            if (Blue(s) > 0) return Way.Blue;
            if (Red(s) > 0) return Way.Red;
            return Way.Error;
        }
    }
}
