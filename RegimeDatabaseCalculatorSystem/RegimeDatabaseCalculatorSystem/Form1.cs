using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace RegimeDatabaseCalculatorSystem
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnCalcCall_Click(object sender, EventArgs e)// Main button to open Calculator form (Selected index = 0)
        {
            Calculators calc = new Calculators(0);
            calc.Show();
        }

        private void btnRegCall_Click(object sender, EventArgs e)//Regime
        {
            Regime regime = new Regime();
            regime.Show();
        }

        #region Menu Objects
        private void CalMenu_Click(object sender, EventArgs e)
        {
            switch ( sender.ToString() )
            {
                case "&BSA":
                    Calculators calcBSA = new Calculators(0);
                    calcBSA.Show();
                    break;
                case "&Cockcroft-Gault":
                    Calculators calcCCR = new Calculators(1);
                    calcCCR.Show();
                    break;
                case "C&alvert":
                    Calculators calcCalvert = new Calculators(2);
                    calcCalvert.Show();
                    break;
            }
        }

        private void regimeEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegimeViewer RV = new RegimeViewer();
            RV.Show();
        }
        

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"User.pdf");
        }
        #endregion
    }
}
