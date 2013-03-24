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
        private void bSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcBSA = new Calculators(0);		// BSA
            calcBSA.Show();
        }

        private void renalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcCCR = new Calculators(1);		// eCCR
            calcCCR.Show();
        }

        private void calvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcCalvert = new Calculators(2);	// Calvert
            calcCalvert.Show();
        }

        private void regimeEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegimeViewer RV = new RegimeViewer();
            RV.Show();
        }
        #endregion

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"User.pdf");
        }
    }
}
