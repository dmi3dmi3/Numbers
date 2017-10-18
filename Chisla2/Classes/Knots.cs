using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla2.Classes
{
    static class Knots
    {
        static public WordIfno[] wordIfno = new WordIfno[6];
        static public string[] Chislo { set; get; }
        static public string ErrMes;
        static public int Result;
        static WordIfno errWI;

        static bool EndCheck()
        {
            int k = 0;
            foreach (WordIfno item in wordIfno)
                if (item != null)
                    k++;
            if (k == Chislo.Count())
                return true;
            errWI = Units.Check(Chislo[k]);
            switch (errWI.Way)
            {
                case WordIfno.ways.Black:
                    ErrMes = " не может идти число единичного формата " + '"' + Chislo[k] + '"';
                    break;
                case WordIfno.ways.Grey:
                    ErrMes = " не может идти " + '"' + Chislo[k] + '"';
                    break;
                case WordIfno.ways.Yellow:
                    ErrMes = " не может идти число десятичтоного формата" + '"' + Chislo[k] + '"';
                    break;
                case WordIfno.ways.Orange:
                    ErrMes = " не может идти число формата 10-19 " + '"' + Chislo[k] + '"';
                    break;
                case WordIfno.ways.Green:
                    ErrMes = " не может идти " + '"' + Chislo[k] + '"';
                    break;
                case WordIfno.ways.Error:
                default:
                    ErrMes = " идет нераспознанное слово " + '"' + Chislo[k] + '"';
                    break;
            }
            return false;
        }

        static void Clear()
        {
            for (int i = 0; i < 6; i++)
                wordIfno[i] = null;
            ErrMes = "";
            Result = -34404;
        }

        static public bool Alfa()
        {
            Clear();
            wordIfno[0] = Units.Check(Chislo[0]);
            Result = wordIfno[0].Res;
            switch (wordIfno[0].Way)
            {
                case WordIfno.ways.Black:
                    if (EndCheck())
                    {
                        if (Result == 1 && !wordIfno[0].HelpFlag)
                        {
                            ErrMes = "Орфографическая ошибка. Возможно вы имели в виду 1 'eins'";
                            return false;
                        }
                        if (Result == 6 && !wordIfno[0].HelpFlag)
                        {
                            ErrMes = "Орфографическая ошибка. Возможно вы имели в виду 6 'sechs'";
                            return false;
                        }
                        if (Result == 7 && !wordIfno[0].HelpFlag)
                        {
                            ErrMes = "Орфографическая ошибка. Возможно вы имели в виду 7 'sieben'";
                            return false;
                        }
                        return true;
                    }      
                    return Beta();

                case WordIfno.ways.Grey:
                    if (EndCheck())
                        return true;
                    return Charlie();

                case WordIfno.ways.Yellow:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа десятичного формата " + '"' + Chislo[0] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Orange:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа формата 10-19 " + '"' + Chislo[0] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Green:
                    ErrMes = "Слово не может начинаться с und";
                    return false;

                default:
                    ErrMes = "Невозможно расопзнать слово " + Chislo[0];
                    return false;
            }
        }

        static bool Beta()
        {
            wordIfno[1] = Units.Check(Chislo[1]);
            ErrMes = "После числа единичного формата " + '"' + Chislo[0] + '"' + ErrMes;
            switch (wordIfno[1].Way)
            {
                case WordIfno.ways.Black:
                    return false;

                case WordIfno.ways.Grey:
                    if (EndCheck())
                    {
                        Result = wordIfno[0].Res * wordIfno[1].Res;
                        return true;
                    }
                    return Delta();
                case WordIfno.ways.Yellow:
                    return false;

                case WordIfno.ways.Orange:
                    return false;

                case WordIfno.ways.Green:
                    if (EndCheck())
                    {
                        ErrMes = "Слово не может заканчиваться на und";
                        return false;
                    }

                    wordIfno[2] = Units.Check(Chislo[2]);
                    if (wordIfno[2].Way == WordIfno.ways.Yellow)
                    {
                        if (EndCheck())
                        {
                            Result = wordIfno[0].Res + wordIfno[2].Res;
                            return true;
                        }
                        ErrMes = "После числа десятичного формата " + '"' + Chislo[2] + '"' + ErrMes;
                        return false;
                    }
                    ErrMes = "После und" + ErrMes;
                    return false;

                case WordIfno.ways.Error:
                default:
                    return false;
            }
        }

        static bool Charlie()
        {
            wordIfno[1] = Units.Check(Chislo[1]);
            ErrMes = "После " + '"' + Chislo[0] + '"' + ErrMes;
            Result = wordIfno[0].Res + wordIfno[1].Res;
            switch (wordIfno[1].Way)
            {
                case WordIfno.ways.Black:
                    if (EndCheck())
                        return true;
                    return Echo();

                case WordIfno.ways.Grey:
                    return false;

                case WordIfno.ways.Yellow:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа десятичного формата " + '"' + Chislo[1] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Orange:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа формата 10-19 " + '"' + Chislo[1] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Green:
                    return false;

                case WordIfno.ways.Error:
                default:
                    return false;
            }
        }

        static bool Delta()
        {
            wordIfno[2] = Units.Check(Chislo[2]);
            ErrMes = "После " + '"' + Chislo[1] + '"' + ErrMes;
            Result = wordIfno[0].Res * wordIfno[1].Res + wordIfno[2].Res;
            switch (wordIfno[2].Way)
            {
                case WordIfno.ways.Black:
                    if (EndCheck())
                        return true;
                    return Foxtrot();

                case WordIfno.ways.Grey:
                    return false;

                case WordIfno.ways.Yellow:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа десятичного формата " + '"' + Chislo[2] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Orange:
                    if (EndCheck())
                        return true;
                    ErrMes = "После числа формата 10-19 " + '"' + Chislo[2] + '"' + ErrMes;
                    return false;

                case WordIfno.ways.Green:
                    return false;

                case WordIfno.ways.Error:
                default:
                    return false;
            }
        }

        static bool Echo()
        {
            wordIfno[2] = Units.Check(Chislo[2]);
            ErrMes = "После числа единичного формата" + '"' + Chislo[1] + '"' + ErrMes;
            Result = wordIfno[0].Res + wordIfno[1].Res;
            if (wordIfno[2].Way == WordIfno.ways.Green)
            {
                if (EndCheck())
                {
                    ErrMes = "Число не может заканчиваться на und";
                    return false;
                }
                wordIfno[3] = Units.Check(Chislo[3]);
                if (wordIfno[3].Way == WordIfno.ways.Yellow)
                {
                    if (EndCheck())
                    {
                        Result += wordIfno[3].Res;
                        return true;
                    }
                    ErrMes = "После числа десятичного формата " + '"' + Chislo[3] + '"' + ErrMes;
                    return false;
                }
                ErrMes = "После und" + ErrMes;
                return false;
            }
            return false;

        }
        static bool Foxtrot()
        {
            wordIfno[3] = Units.Check(Chislo[3]);
            ErrMes = "После числа единичного формата " + '"' + Chislo[2] + '"' + ErrMes;
            Result = wordIfno[0].Res * wordIfno[1].Res + wordIfno[2].Res;
            if (wordIfno[3].Way == WordIfno.ways.Green)
            {
                if (EndCheck())
                {
                    ErrMes = "Число не может заканчиваться на und";
                    return false;
                }
                wordIfno[4] = Units.Check(Chislo[4]);
                if (wordIfno[4].Way == WordIfno.ways.Yellow)
                {
                    if (EndCheck())
                    {
                        Result += wordIfno[4].Res;
                        return true;
                    }
                    ErrMes = "После числа десятичного формата " + '"' + Chislo[4] + '"' + ErrMes;
                    return false;
                }
                ErrMes = "После und" + ErrMes;
                return false;
            }
            return false;
        }
    }
}
