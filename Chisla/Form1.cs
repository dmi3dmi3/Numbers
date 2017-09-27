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
            switch (LiteChecker.Check(Tools.Remove(translator.tmp_chislo, 3)))
            {
                case LiteChecker.Way.Black:
                    break;
                case LiteChecker.Way.Orange:
                    wm = FullCheker.FCheck(LiteChecker.Way.Orange, translator.tmp_chislo);
                    if (ErrorCheck(wm))
                        return;
                    if (!EndCheck(wm.res, wm.num))
                        return;
                    OutputLBL.Text = "10";
                    return;
                case LiteChecker.Way.Brown:
                    break;
                case LiteChecker.Way.Grey:
                    break;
                case LiteChecker.Way.Red:
                    OutputLBL.Text = "Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Red";
                        return;
                case LiteChecker.Way.Yellow:
                    OutputLBL.Text = "Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Yellow";
                        return;
                case LiteChecker.Way.Green:
                    OutputLBL.Text = "Число не может начинаться с und";
                    return;
                case LiteChecker.Way.Blue:
                    OutputLBL.Text = "Эта ошибка не может появиться. Если она появилась, то что-то совсем не так. 1Blue";
                    return;
                case LiteChecker.Way.Error:
                    ErrorCheck(new WordMeaning(true, 0, 3, true));
                    return;
                default:
                    break;
            }

        }

        private void Underline(int a)
        {

        }

        private bool ErrorCheck(WordMeaning wm)
        {
            if (wm.err == false)
                return false;
            OutputLBL.Text = "Орфографическая ошибка.";
            if (wm.res != 0)
                OutputLBL.Text += " Возможно вы имели в виду " + wm.res.ToString() + ".";
            Underline(wm.num);
            return true;
        }

        private bool EndCheck(int res, int num)
        {
            if (translator.chislo.Count() == num)
                return true;
            OutputLBL.Text = "Это число " + res.ToString() + ". Но после него есть лишние смволы (" + (translator.chislo.Count() - num).ToString() + ").";
            Underline(translator.chislo.Count() + num);
            return false;
        }
    }
}
