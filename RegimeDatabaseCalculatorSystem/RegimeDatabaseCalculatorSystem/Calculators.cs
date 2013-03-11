using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegimeDatabaseCalculatorSystem
{
    public partial class Calculators : Form
    {
        public Calculators(int tab)
        {
            InitializeComponent();
            tabCalculators.SelectedIndex = tab;
        }

        private void btnBSA_Click(object sender, EventArgs e)  //BSA Frontend code-GUI interface
        {
            int BSAErrorCode = 0;
            tbBSA.BackColor = Color.White; //Resets tb bg Color.
            Validator BSAval = new Validator();

            TextBox[] BSAinputs = { tbWeight, tbHeight };
            foreach (TextBox TB in BSAinputs)
            {
                int BSAstatus = BSAval.Check(1, 0, TB.Text);
                if (BSAstatus != 0)					//If error show warning, change bg colour & Skip calculation
                {
                    TB.BackColor = Color.Red;
                    BSAErrorCode = BSAstatus;		//!!
                    tbBSA.Clear();
                    goto EOF;
                }
                else TB.BackColor = Color.White;
            }
            double Weight = double.Parse(tbWeight.Text);
            double Height = double.Parse(tbHeight.Text);
            cBSA currentBSA = new cBSA();
            double ans = Math.Round(currentBSA.BSA(Height, Weight), 1);
            if ( ans > 2 )  //Validation to prevent high doses BSA usually has a ceiling of 2.
            {
                string txtOut = "BSA is: " + ans.ToString() + "\nPlease discuss with the Consultant before using values greater than 2 in dosage calculations.\nPress OK accept a BSA value of 2 or Cancel to continue with existing value.";
                DialogResult choice = MessageBox.Show(txtOut, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if ( choice == DialogResult.OK )
                {
                    ans = 2.0;
                }
                else
                {
                    tbBSA.BackColor = Color.Red;
                }
            }
            tbBSA.Text = ans.ToString();
        EOF:
            BSAval.ErrorMessage(BSAErrorCode);
        }

        private void btneCCR_Click(object sender, EventArgs e)  //eCCR Frontend code-GUI interface
        {
            int eCCRErrorCode = 0;
            Validator eCCRval = new Validator();
            TextBox[] eCCRinputs = { tbMass, tbSC, tbAge };
            foreach (TextBox TB in eCCRinputs)
            {
                int eCCRstatus = eCCRval.Check(TB.Name == "tbAge" ? 0 : 1, 0, TB.Text);
                if (eCCRstatus != 0)
                {
                    TB.BackColor = Color.Red;
                    eCCRErrorCode = eCCRstatus;
                    tbCCr.Clear();
                    goto EOF;

                }
                else TB.BackColor = Color.White;
            }

            int age = int.Parse(tbAge.Text);
            double Mass = double.Parse(tbMass.Text);
            double SCreat = double.Parse(tbSC.Text);
            string g;
            if ( checkBox1.Checked == true )
            {
                g = "M";
            }
            else
            {
                g = "F";
            }
            cCCr currentCCR = new cCCr();
            double ans = currentCCR.CCR(age, Mass, SCreat, g);
            tbCCr.Text = Math.Round(ans, 0).ToString();
        EOF:
            eCCRval.ErrorMessage(eCCRErrorCode);
        }

        private void btnCa_Click(object sender, EventArgs e)  //Calvert Frontend code-GUI interface
        {
            int CaErrorCode = 0;
            Validator eCalval = new Validator();
            TextBox[] eCCRinputs = { tbAUC, tbGFR };
            foreach (TextBox TB in eCCRinputs)
            {
                int 
                	CalStatus = eCalval.Check(0, 0, TB.Text);
                if (CalStatus != 0 )
                {
                    TB.BackColor = Color.Red;
                    CaErrorCode = CalStatus;
                    tbDose.Clear();
                    goto EOF;

                }
                else TB.BackColor = Color.White;
            }

            int auc = int.Parse(tbAUC.Text);
            int gfr = int.Parse(tbGFR.Text);
            cCalvert currentCalvert = new cCalvert();
            int ans = currentCalvert.Calvert(auc, gfr);
            tbDose.Text = ans.ToString();
        EOF:
            eCalval.ErrorMessage(CaErrorCode);
        }

        private void button3_Click(object sender, EventArgs e)//Copies Result of eCCR to Calvert & Jumps to the Calvert tab.
        {
            tbGFR.Text = tbCCr.Text;
            tabCalculators.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e) //Jumps from Calvert tab to eCCR.
        {
            tabCalculators.SelectedIndex = 1;
        }

        private void tbCCr_TextChanged(object sender, EventArgs e) //Only activates btnUse4Calvert when tb populated
        {
            if (tbCCr.Text == "")
            {
                btnUse4Calvert.Enabled = false;
            }
            else btnUse4Calvert.Enabled = true;
        }
    }
}
