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

        private void btnCalcCall_Click(object sender, EventArgs e)// Calculators
        {
            Calculators calc = new Calculators(0);
            calc.Show();
        }

        #region Toolbar Objects
        private void bSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcBSA = new Calculators(0);
            calcBSA.Show();
        }

        private void renalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcCCR = new Calculators(1);
            calcCCR.Show();
        }

        private void calvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculators calcCalvert = new Calculators(2);
            calcCalvert.Show();
        }

        private void regimeEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegimeViewer RV = new RegimeViewer();
            RV.Show();
        }        

        #endregion
        
        private void btnRegCall_Click(object sender, EventArgs e)//Regime
        {
            Regime regime = new Regime();
            regime.Show();
        }
    }
}
