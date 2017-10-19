using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chisla2.Classes;

namespace Chisla2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            Translator translator = new Translator(InputTB.Text);
            InputTB.Text = translator.str_chislo;
            Knots.Chislo = translator.chislo;
            Chislo = translator.chislo;

            if (Knots.Alfa())
                OutputLbl.Text = Knots.Result.ToString();
            else
            {
                OutputLbl.Text = Knots.ErrMes;
                Underline();
            }
        }

        private void InputTB_TextChanged(object sender, EventArgs e)
        {
            paintFlag = false;
            Invalidate();
        }

        bool paintFlag = false;
        float st, en;
        string[] Chislo { set; get; }


        public void Underline()
        {
            paintFlag = true;
            Graphics g = Graphics.FromHwnd(Handle);
            string s = "";
            if (Knots.undlin >= Chislo.Count() || Knots.undlin < 0) return;
            for (int i = 0; i < Knots.undlin; i++)
            {
                s += Chislo[i] + " ";
            }
            st = g.MeasureString(s, InputTB.Font).Width;
            s += Chislo[Knots.undlin];
            en = g.MeasureString(s, InputTB.Font).Width;
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (paintFlag)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Point a, b;
                a = new Point(
                    InputTB.Left + (int)st,
                    InputTB.Top + InputTB.Height
                    );
                b = new Point(-2 - Knots.undlin * 3 +
                    InputTB.Left + (int)en,
                    InputTB.Top + InputTB.Height
                    );
                g.DrawLine(new Pen(Color.Red, 4), a, b);
            }
        }
    }
}
