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
        WordMeaning wm = new WordMeaning();
        Queue<WordMeaning> result;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            if (InputTB.Text.Count()<3)
            {
                OutputLBL.Text = "Необходимо ввести не меньше 3х символов";
                return;
            }
            translator.Set(InputTB.Text);
            switch (LiteChecker.Check(translator.TakeBegining()))
            {
                case LiteChecker.Way.Black:
                    wm = FullCheker.FCheck(LiteChecker.Way.Black, translator.tmp_chislo);
                    if (ErrorCheck(wm))
                        return;
                    if (wm.res == 20)
                    {
                        if (!EndCheck(20, 7))
                            return;
                        Output(20);
                    }
                    translator.Cut(wm.num);
                    switch (LiteChecker.Check(translator.TakeBegining()))
                    {
                        case LiteChecker.Way.Black:
                            Output("После " + wm.res.ToString() + " не модет идти число единичного формата");
                            return;
                        case LiteChecker.Way.Orange:
                            break;
                        case LiteChecker.Way.Brown:
                            Output(1);
                            break;
                        case LiteChecker.Way.Grey:
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

                    return;
                case LiteChecker.Way.Orange:
                    wm = FullCheker.FCheck(LiteChecker.Way.Orange, translator.tmp_chislo);
                    result.Enqueue(wm);
                    if (ErrorCheck(wm))
                        return;
                    if (!EndCheck(wm.res, wm.num))
                        return;
                    Output(wm.res);
                    return;
                case LiteChecker.Way.Brown:
                    wm = FullCheker.FCheck(LiteChecker.Way.Brown, translator.tmp_chislo);
                    if (ErrorCheck(wm))
                        return;
                    if (!EndCheck(wm.res, wm.num))
                        return;
                    Output(wm.res);
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

        private void Underline(int a, int b)
        {

        }

        private bool ErrorCheck(WordMeaning wm)
        {
            if (wm.err == false)
                return false;
            Output("Орфографическая ошибка.");
            if (wm.res != 0)
                Output(" Возможно вы имели в виду " + wm.res.ToString() + ".");
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
