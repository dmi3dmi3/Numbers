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

            if (Knots.Alfa())
                OutputLbl.Text = Knots.Result.ToString();
            else
                OutputLbl.Text = Knots.ErrMes;
        }
    }
}
