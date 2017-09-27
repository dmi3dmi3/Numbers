using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla.Classes
{
    static class FullCheker
    {
        /** new WordMeaning(false, 1, 1, false);
         * error
         * result
         * count
         * endFlag
         **/
        static public WordMeaning FCheck(LiteChecker.Way way, String s)
        {
            int ch;
            switch (way)
            {
                case LiteChecker.Way.Black:
                    ch = LiteChecker.Black(Tools.Remove(s, 3));  
                    switch (ch)
                    {
                        case 1:
                            if (Tools.Remove(s, 3) == "ein")
                                if (Tools.Remove(s,4) == "eins")
                                    return new WordMeaning(false, 1, 4, true);
                                else
                                    return new WordMeaning(false, 1, 3, false);
                            else
                                return new WordMeaning(true, 1, 3, true);
                        case 2:
                            if (Tools.Remove(s, 4) == "zwan")
                                if (Tools.Remove(s, 7) == "zwanzig")
                                    return new WordMeaning(false, 20, 7, true);
                                else
                                    return new WordMeaning(true, 20, 7, true);
                            else if (Tools.Remove(s,4) == "zwei")
                                return new WordMeaning(false, 2, 4, false);
                            else
                                return new WordMeaning(true, 2, 4, true);
                        case 3:
                            if (Tools.Remove(s,4) == "drei")
                                return new WordMeaning(false, 3, 4, false);
                            else
                                return new WordMeaning(true, 3, 4, true);
                        case 4:
                            if (Tools.Remove(s,4) == "vier")
                                return new WordMeaning(false, 4, 4, false);
                            else
                                return new WordMeaning(true, 4, 4, true);
                        case 5:
                            if (Tools.Remove(s, 4) == "funf")
                                return new WordMeaning(false, 5, 4, false);
                            else
                                return new WordMeaning(true, 5, 4, true);
                        case 6:
                            if (Tools.Remove(s, 4) == "sech")
                                if (Tools.Remove(s, 5) == "sechs")
                                    return new WordMeaning(false, 6, 5, true);
                                else
                                    return new WordMeaning(false, 6, 4, false);
                            else
                                return new WordMeaning(true, 6, 4, true);
                        case 7:
                            if (Tools.Remove(s, 4) == "sieb")
                                if (Tools.Remove(s, 6) == "sieben")
                                    return new WordMeaning(false, 7, 6, true);
                                else
                                    return new WordMeaning(false, 7, 4, false);
                            else
                                return new WordMeaning(true, 7, 4, true);
                        case 8:
                            if (Tools.Remove(s, 4) == "acht")
                                return new WordMeaning(false, 8, 4, false);
                            else
                                return new WordMeaning(true, 8, 4, true);
                        case 9:
                            if (Tools.Remove(s, 4) == "neun")
                                return new WordMeaning(false, 9, 4, false);
                            else
                                return new WordMeaning(true, 9, 4, true);
                    }
                    return new WordMeaning(true, 0, 3, true);
                case LiteChecker.Way.Orange:
                    if (Tools.Remove(s, 4) == "zehn")
                        return new WordMeaning(false, 10, 4, true);
                    else
                        return new WordMeaning(true, 10, 4, true);
                case LiteChecker.Way.Brown:
                    if (Tools.Remove(s,3) == "elf")
                        return new WordMeaning(false, 11, 3, true);
                    else if (Tools.Remove(s,5) == "zwolf")
                        return new WordMeaning(false, 12, 5, true);
                    else
                        return new WordMeaning(true, 12, 5, true);
                case LiteChecker.Way.Grey:
                    if (Tools.Remove(s,7) == "hundert")
                        return new WordMeaning(false, 100, 7, false);
                    else
                        return new WordMeaning(true, 100, 7, true);
                case LiteChecker.Way.Red:
                    if (Tools.Remove(s,1) == "s")
                        if (s.Count() == 1)
                            return new WordMeaning(false, 0, 1, true);
                        else if(LiteChecker.Check(Tools.TakeEnd(s, 1)) == LiteChecker.Way.Grey)
                            return new WordMeaning(false, 0, 1, false);
                        else
                            return new WordMeaning(true, 0, 1, true);
                    else if (Tools.Remove(s,2) == "en")
                            if (s.Count() == 2)
                                return new WordMeaning(false, 0, 2, true);
                            else if (LiteChecker.Check(Tools.TakeEnd(s, 1)) == LiteChecker.Way.Grey)
                                return new WordMeaning(false, 0, 2, false);
                            else
                                return new WordMeaning(true, 0, 2, true);
                    else if (true)
                            if (s.Count() == 0)
                                return new WordMeaning(false, 0, 0, true);
                            else if (LiteChecker.Check(Tools.TakeEnd(s, 1)) == LiteChecker.Way.Grey)
                                return new WordMeaning(false, 0, 0, false);
                            else
                                return new WordMeaning(true, 0, 1, true);
                case LiteChecker.Way.Yellow:
                    return new WordMeaning(false, 10, 3, true);
                case LiteChecker.Way.Green:
                    return new WordMeaning(false, 10, 3, false);
                case LiteChecker.Way.Blue:
                    ch = LiteChecker.Black(Tools.Remove(s, 3));
                    switch (ch)
                    {
                        case 2:
                            if (Tools.Remove(s, 4) == "zwan")
                                    return new WordMeaning(false, 2, 4, true);
                                else
                                    return new WordMeaning(true, 2, 4, true);
                        case 3:
                            if (Tools.Remove(s, 4) == "drei")
                                return new WordMeaning(false, 3, 4, false);
                            else
                                return new WordMeaning(true, 3, 4, true);
                        case 4:
                            if (Tools.Remove(s, 4) == "vier")
                                return new WordMeaning(false, 4, 4, false);
                            else
                                return new WordMeaning(true, 4, 4, true);
                        case 5:
                            if (Tools.Remove(s, 4) == "funf")
                                return new WordMeaning(false, 5, 4, false);
                            else
                                return new WordMeaning(true, 5, 4, true);
                        case 6:
                            if (Tools.Remove(s, 4) == "sech")
                                return new WordMeaning(false, 6, 4, false);
                            else
                                return new WordMeaning(true, 6, 4, true);
                        case 7:
                            if (Tools.Remove(s, 4) == "sieb")
                                return new WordMeaning(false, 7, 4, false);
                            else
                                return new WordMeaning(true, 7, 4, true);
                        case 8:
                            if (Tools.Remove(s, 4) == "acht")
                                return new WordMeaning(false, 8, 4, false);
                            else
                                return new WordMeaning(true, 8, 4, true);
                        case 9:
                            if (Tools.Remove(s, 4) == "neun")
                                return new WordMeaning(false, 9, 4, false);
                            else
                                return new WordMeaning(true, 9, 4, true);
                    }
                    return new WordMeaning(true, 0, 3, true);
                case LiteChecker.Way.Error:
                        return new WordMeaning(true, 0, 3, true);
                default:
                    return new WordMeaning(true, 0, 3, true);
            }
        }
    }
}
