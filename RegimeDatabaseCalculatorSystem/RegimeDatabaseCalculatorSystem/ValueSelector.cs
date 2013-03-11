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
    public partial class ValueSelector : Form
    {
        public ValueSelector(string Purpose)
        {
            InitializeComponent();
            if ( Purpose == "D") //Diagnosis
            {
                clbValues.Items.Clear();
                clbValues.Items.Add("War");
                clbValues.Items.Add("Famine");
                clbValues.Items.Add("Plague");
                clbValues.Items.Add("Death");
                clbValues.Items.Add("Rhonnie");
            }
            else if ( Purpose == "P" ) //Prescriptions
            {

            }
        }
    }
}
