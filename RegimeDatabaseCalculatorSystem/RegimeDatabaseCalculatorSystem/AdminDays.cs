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
    public partial class AdminDays : Form
    {
        //public bool Submit = false;
        public int lDaysPerCycle;
        public  AdminDays(int DaysPerCycle)
        {
            InitializeComponent();
            lDaysPerCycle = DaysPerCycle;
            for (int i = 1; i <= DaysPerCycle; i++)
            {
                lbDayCycle.Items.Add(i);
            }
        }

        public List<int> Days()
        {
            List<int> DoseDays = new List<int>();
            for (int i = 0; i < lDaysPerCycle; i++)
            {
                if (lbDayCycle.GetItemChecked(i))
                {
                    DoseDays.Add(i + 1);  //+1 to resolve issue with different index bases  
                }
            }
            return DoseDays;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    Submit = true;
        //}
        
        private void FrmDayCycle_SizeChanged(object sender, EventArgs e)    //Resize
        {
            int h = this.Size.Height - 50;
            lbDayCycle.Size = new Size(this.Size.Width - 5, h);
        }
    }
}
