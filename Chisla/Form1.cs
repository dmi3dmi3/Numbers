using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chisla.Classes;

namespace Chisla
{
    public partial class Form1 : Form
    {
        Translator translator = new Translator();
        //WordMeaning wm = new WordMeaning();
        WordMeaning[] wm = new WordMeaning[4];
        public Form1()
        {
            InitializeComponent();
            

        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            if (InputTB.Text.Count()<3)
            {
                Output("Необходимо ввести не меньше 3х символов");
                return;
            }
            translator.Set(InputTB.Text);


            switch (LiteChecker.Check(translator.TakeBegining()))
            {
                case LiteChecker.Way.Black:
                    wm[0] = FullCheker.FCheck(LiteChecker.Way.Black, translator.tmp_chislo);

                    if (ErrorCheck(wm[0]))
                        return;
                    if (wm[0].res == 20)
                    {
                        if (!EndCheck(20, 7))
                            return;
                        Output(20);
                    }
                    if (wm[0].num == translator.chislo.Count()) {
                        if (wm[0].res == 1 && !wm[0].helpFlag)
                        {
                            Output("Возможно вы имели в виду 1 (eins)");
                            return;
                        }
                        if (wm[0].res == 6 && !wm[0].helpFlag)
                        {
                            Output("Возможно вы имели в виду 6 (sechs)");
                            return;
                        }
                    if (wm[0].res == 7 && !wm[0].helpFlag)
                        { 
                            Output("Возможно вы имели в виду 7 (sieben)");
                            return;
                        }
                        Output(wm[0].res);
                        return;
                    }
                    translator.Cut(wm[0].num);
                    switch (LiteChecker.Check(translator.TakeBegining()))
                    {
                        case LiteChecker.Way.Black:
                            Output("После " + wm[0].res.ToString() + " не может идти число единичного формата");
                            return;
                        case LiteChecker.Way.Orange:
                            if (wm[0].res == 1 || wm[0].res == 2)
                            {
                                Output("После " + wm[0].res + " не может идти zehn");
                                Underline(wm[0].num);
                                return;
                            }
                            if (wm[0].res == 6 && wm[0].helpFlag)
                            {
                                Output("Возможно вы имели в виду 16");
                                Underline(5, 5);
                                return;
                            }
                            if (wm[0].res == 7 && wm[0].helpFlag)
                            {
                                Output("Возможно вы имели в виду 17");
                                Underline(5, 6);
                                return;
                            }
                            wm[1] = FullCheker.FCheck(LiteChecker.Way.Orange, translator.tmp_chislo);
                            if (ErrorCheck(wm[1]))
                                return;
                            if (!EndCheck(wm[1].res + wm[0].res, wm[1].num+wm[0].num))
                                return;
                            Output(wm[1].res + wm[0].res);
                            return;
                        case LiteChecker.Way.Brown:
                            wm[1] = FullCheker.FCheck(LiteChecker.Way.Brown, translator.tmp_chislo);
                            Output("После " + wm[0].res + " не может идти " + wm[1].res + ".");
                            Underline(wm[0].num);
                            return;
                        case LiteChecker.Way.Grey:
                            wm[1] = FullCheker.FCheck(LiteChecker.Way.Grey, translator.tmp_chislo);
                            if (ErrorCheck(wm[1]))
                                return;
                            if (wm[0].num + wm[1].num == translator.chislo.Count())
                            {
                                if (wm[0].res == 1 && !wm[0].helpFlag)
                                {
                                    Output("Возможно вы имели в виду 100 (einshundret)");
                                    return;
                                }
                                if (wm[0].res == 6 && !wm[0].helpFlag)
                                {
                                    Output("Возможно вы имели в виду 6 (sechshundret)");
                                    return;
                                }
                                if (wm[0].res == 7 && !wm[0].helpFlag)
                                {
                                    Output("Возможно вы имели в виду 7 (siebenhundret)");
                                    return;
                                }
                                Output(wm[0].res * wm[1].res);
                                return;
                            }
                            translator.Cut(wm[1].num);
                            switch (LiteChecker.Check(translator.TakeBegining()))
                            {
                                case LiteChecker.Way.Black:
                                    break;
                                case LiteChecker.Way.Orange:
                                    wm[2] = FullCheker.FCheck(LiteChecker.Way.Orange, translator.tmp_chislo);
                                    if (ErrorCheck(wm[2]))
                                        return;
                                    if (!EndCheck(wm[0].res * wm[1].res + wm[2].res, wm[0].num + wm[1].num + wm[2].num))
                                        return;
                                    Output(wm[0].res * wm[1].res + wm[2].res);
                                    return;
                                case LiteChecker.Way.Brown:
                                    wm[2] = FullCheker.FCheck(LiteChecker.Way.Brown, translator.tmp_chislo);
                                    if (ErrorCheck(wm[2]))
                                        return;
                                    if (!EndCheck(wm[0].res * wm[1].res + wm[2].res, wm[0].num + wm[1].num + wm[2].num))
                                        return;
                                    Output(wm[0].res * wm[1].res + wm[2].res);
                                    break;
                                case LiteChecker.Way.Grey:
                                    wm[2] = FullCheker.FCheck(LiteChecker.Way.Grey, translator.tmp_chislo);
                                    if (ErrorCheck(wm[2]))
                                        return;
                                    Output("После hundert не может идти hundert. Это уже перебор.");
                                    break;
                                case LiteChecker.Way.Red:
                                    break;
                                case LiteChecker.Way.Yellow:
                                    break;
                                case LiteChecker.Way.Green:
                                    break;
                                case LiteChecker.Way.Blue:
                                    break;
                                case LiteChecker.Way.Error:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case LiteChecker.Way.Red:
                            Output(2);
                            break;
                        case LiteChecker.Way.Yellow:
                            break;
                        case LiteChecker.Way.Green:
                            break;
                        case LiteChecker.Way.Blue:
                            break;
                        case LiteChecker.Way.Error:
                            Output("Error1");
                            return;
                        default:
                            break;
                    }

                    return;
                case LiteChecker.Way.Orange:
                    wm[0] = FullCheker.FCheck(LiteChecker.Way.Orange, translator.tmp_chislo);
                    if (ErrorCheck(wm[0]))
                        return;
                    if (!EndCheck(wm[0].res, wm[0].num))
                        return;
                    Output(wm[0].res);
                    return;
                case LiteChecker.Way.Brown:
                    wm[0] = FullCheker.FCheck(LiteChecker.Way.Brown, translator.tmp_chislo);
                    if (ErrorCheck(wm[0]))
                        return;
                    if (!EndCheck(wm[0].res, wm[0].num))
                        return;
                    Output(wm[0].res);
                    return;
                case LiteChecker.Way.Grey:
                    break;
                case LiteChecker.Way.Red:
                    Output("Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Red");
                        return;
                case LiteChecker.Way.Yellow:
                    Output("Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Yellow");
                        return;
                case LiteChecker.Way.Green:
                    OutputLBL.Text = "Число не может начинаться с und";
                    return;
                case LiteChecker.Way.Blue:
                    Output("Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Blue");
                    return;
                case LiteChecker.Way.Error:
                    ErrorCheck(new WordMeaning(true, 0, 3, true));
                    return;
                default:
                    break;
            }
        }

        //Подчернкуть от а до б включительно
        private void Underline(int a, int b)
        {

        }

        //Подчернкуть от а до конца включительно
        private void Underline(int a)
        {

        }

        private bool ErrorCheck(WordMeaning wm)
        {
            if (wm.err == false)
                return false;
            Output("Орфографическая ошибка.");
            if (wm.res != 0)
                Output("Орфографическая ошибка. Возможно вы имели в виду " + wm.res.ToString() + ".");
            //Underline(0, wm.num);
            return true;
        }

        private bool EndCheck(int res, int num)
        {
            if (translator.chislo.Count() == num)
                return true;
            Output("Это число " + res.ToString() + ". Но после него есть лишние смволы (" + (translator.chislo.Count() - num).ToString() + ").");
            //Underline(translator.chislo.Count() + num);
            return false;
        }

        private void Output(int a)
        {
            OutputLBL.Text = a.ToString() ;
        }

        private void Output(string s)
        {
            OutputLBL.Text = s;
        }
    }
}
