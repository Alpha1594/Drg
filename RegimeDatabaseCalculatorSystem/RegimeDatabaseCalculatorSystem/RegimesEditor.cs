using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace RegimeDatabaseCalculatorSystem
{
    public partial class RegimesEditor : Form
    {
        public RegimesEditor(int ChosenRegime, bool IsNew)
        {
            InitializeComponent();
            pIsNew = IsNew;
            pIndex = ChosenRegime;
            TextBox[] TBurl = { tbURL1, tbURL2, tbURL3 };
            if ( !IsNew )
            {
                loadRegime(ChosenRegime);
                btnSave.Text = "Update";
            }
        }

        public struct Doses
        {
            public string DrgName;
            public float DrgDose;
            public string CalcMethod;
            public string DrgAdmin;
            public string Path;
            public List<int> AdministrationDays;
            public Doses(string DrgName, float DrgDose, string CalcMethod, string DrgAdmin, string Path, List<int> AdministrationDays)
            {
                this.DrgName = DrgName;
                this.DrgDose = DrgDose;
                this.CalcMethod = CalcMethod;
                this.DrgAdmin = DrgAdmin;
                this.Path = Path;
                this.AdministrationDays = AdministrationDays;
            }
        }
        public struct RegimeData
        {
            public string RegName;
            public string[] Desc;
            public string Extravasation;
            public string[] Comments;
            public List<Doses> RegimeDoses;
            public int NoOfCycles;
            public int DaysPerCycle;
            public RegimeData(string RegName, string[] Desc, string Extravasation, string[] Comments, List<Doses> LatestDose, int NoOfCycles, int DaysPerCycle)// 
            {
                this.RegName = RegName;
                this.Desc = Desc;
                this.Extravasation = Extravasation;
                this.Comments = Comments;
                this.RegimeDoses = LatestDose;
                this.NoOfCycles = NoOfCycles;
                this.DaysPerCycle = DaysPerCycle;

            }
        }
        public static List<RegimeData> RegimeList = new List<RegimeData>();
        public void ReadRegimes()  //Accesses existing patient data from file; Populates List<RegimeList>
        {
            XmlSerializer XSR = new XmlSerializer(typeof(List<RegimeData>));
        PopulateList:
            if ( File.Exists("Regimes.xml") )
            {
                FileStream XFile = new FileStream("Regimes.xml", FileMode.Open);
                if ( XFile.Length > 0 )
                {
                    RegimeList = (List<RegimeData>) XSR.Deserialize(XFile);
                }
                XFile.Close();
            }
            else
            {
                FileStream XFile = new FileStream("Regimes.xml", FileMode.CreateNew);
                XFile.Close();
                goto PopulateList;
            }
        }
        List<int> D1Days = new List<int>();
        List<int> D2Days = new List<int>();
        List<int> D3Days = new List<int>();
        List<int> D4Days = new List<int>();

        public UriBuilder EMCurl = new UriBuilder();
        public bool pIsNew;
        public int pIndex;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Validity = true;
            ReadRegimes();          //Populates List<Patient> with existing data
            if ( !pIsNew )
                RegimeList.RemoveAt(pIndex);

            Validator DoseVal = new Validator();

            if ( Validity )
            {
                List<Doses> TheDoses = new List<Doses>();
                if ( tbDose1.Text != "" && tbDose1.Text != "Dose" )
                {
                    int ErrCode = DoseVal.Check(1, 0, tbDose1.Text);
                    if ( ErrCode == 0 )
                    {
                        Doses d1 = new Doses(tbDrugName1.Text, float.Parse(tbDose1.Text), cbCalcMethod1.Text, cbAdmin1.Text, tbURL1.Text, D1Days);
                        TheDoses.Add(d1);
                        tbDose1.BackColor = Color.White;
                    }
                    else
                    {
                        Validity = false;
                        tbDose1.BackColor = Color.Red;
                        DoseVal.ErrorMessage(ErrCode);
                        return;
                    }
                }
                if ( tbDose2.Text != "" && tbDose2.Text != "Dose" )
                {
                    int ErrCode = DoseVal.Check(1, 0, tbDose2.Text);
                    if ( ErrCode == 0 )
                    {
                        Doses d2 = new Doses(tbDrugName2.Text, float.Parse(tbDose2.Text), cbCalcMethod2.Text, cbAdmin2.Text, tbURL2.Text, D2Days);
                        TheDoses.Add(d2);
                        tbDose2.BackColor = Color.White;
                    }
                    else
                    {
                        Validity = false;
                        tbDose2.BackColor = Color.Red;
                        DoseVal.ErrorMessage(ErrCode);
                        return;
                    }
                }

                if ( tbDose3.Text != "" && tbDose3.Text != "Dose" )
                {
                    int ErrCode = DoseVal.Check(1, 0, tbDose3.Text);
                    if ( ErrCode == 0 )
                    {
                        Doses d3 = new Doses(tbDrugName3.Text, float.Parse(tbDose3.Text), cbCalcMethod3.Text, cbAdmin3.Text, tbURL3.Text, D3Days);
                        TheDoses.Add(d3);
                        tbDose3.BackColor = Color.White;
                    }
                    else
                    {
                        Validity = false;
                        tbDose3.BackColor = Color.Red;
                        DoseVal.ErrorMessage(ErrCode);
                        return;
                    }
                }

                if ( tbDose4.Text != "" && tbDose4.Text != "Dose" )
                {
                    int ErrCode = DoseVal.Check(1, 0, tbDose4.Text);
                    if ( ErrCode == 0 )
                    {
                        Doses d4 = new Doses(tbDrugName4.Text, float.Parse(tbDose4.Text), cbCalcMethod4.Text, cbAdmin4.Text, tbURL4.Text, D4Days);
                        TheDoses.Add(d4);
                        tbDose4.BackColor = Color.White;
                    }
                    else
                    {
                        Validity = false;
                        tbDose4.BackColor = Color.Red;
                        DoseVal.ErrorMessage(ErrCode);
                        return;
                    }
                }

                if ( TheDoses.Count > 0 )
                {
                    RegimeData X = new RegimeData(tbRegName.Text, tbDesc.Lines, tbExtravasation.Text, tbComment.Lines, TheDoses, (int) numNoCycles.Value, (int) numDaysCycle.Value);// 
                    XmlSerializer XSR = new XmlSerializer(typeof(List<RegimeData>));	//new instance of XML serialiser to store List PatientDataRecords
                    RegimeList.Add(X);	//Appends latest data to list
                    FileStream DataOut = new FileStream("Regimes.xml", FileMode.Create);	//Creates file object
                    XSR.Serialize(DataOut, RegimeList);   //Outputs data
                    DataOut.Close();	//Closes File
                    string MessageStr = pIsNew ? "Data Recorded" : "Data Updated";
                    MessageBox.Show(MessageStr, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fields incomplete\nData not written", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //    DoseVal.ErrorMessage(ErrorCode);
        }

        private void loadRegime(int RegNum)
        {
            ReadRegimes();
            tbRegName.Text = RegimeList[RegNum].RegName;
            tbDesc.Lines= RegimeList[RegNum].Desc;
            tbExtravasation.Text = RegimeList[RegNum].Extravasation;
            tbComment.Lines= RegimeList[RegNum].Comments;
            numNoCycles.Value = RegimeList[RegNum].NoOfCycles;
            numDaysCycle.Value = RegimeList[RegNum].DaysPerCycle;

            switch ( RegimeList[RegNum].RegimeDoses.Count )
            {
                case 4:
                    tbDrugName4.Text = RegimeList[RegNum].RegimeDoses[3].DrgName;
                    tbDose4.Text = RegimeList[RegNum].RegimeDoses[3].DrgDose.ToString();
                    cbCalcMethod4.Text = RegimeList[RegNum].RegimeDoses[3].CalcMethod.ToString();
                    cbAdmin4.Text = RegimeList[RegNum].RegimeDoses[3].DrgAdmin;
                    tbURL4.Text = RegimeList[RegNum].RegimeDoses[3].Path;

                    D4Days = RegimeList[RegNum].RegimeDoses[3].AdministrationDays;
                    string strD4 = "";
                    foreach ( int i in RegimeList[RegNum].RegimeDoses[3].AdministrationDays )
                    {
                        strD4 += i + ", ";
                    }
                    //strD4 += "]";
                    tbAdminDays4.Text = strD4;
                    goto case 3;

                case 3:
                    tbDrugName3.Text = RegimeList[RegNum].RegimeDoses[2].DrgName;
                    tbDose3.Text = RegimeList[RegNum].RegimeDoses[2].DrgDose.ToString();
                    cbCalcMethod3.Text = RegimeList[RegNum].RegimeDoses[2].CalcMethod.ToString();
                    cbAdmin3.Text = RegimeList[RegNum].RegimeDoses[2].DrgAdmin;
                    tbURL3.Text = RegimeList[RegNum].RegimeDoses[2].Path;

                    D3Days = RegimeList[RegNum].RegimeDoses[2].AdministrationDays;
                    string strD3 = "";
                    foreach ( int i in RegimeList[RegNum].RegimeDoses[2].AdministrationDays )
                    {
                        strD3 += i + ", ";
                    }
                    //strD3 += "]";
                    tbAdminDays3.Text = strD3;
                    goto case 2;

                case 2:
                    tbDrugName2.Text = RegimeList[RegNum].RegimeDoses[1].DrgName;
                    tbDose2.Text = RegimeList[RegNum].RegimeDoses[1].DrgDose.ToString();
                    cbCalcMethod2.Text = RegimeList[RegNum].RegimeDoses[1].CalcMethod.ToString();
                    cbAdmin2.Text = RegimeList[RegNum].RegimeDoses[1].DrgAdmin;
                    tbURL2.Text = RegimeList[RegNum].RegimeDoses[1].Path;

                    D2Days = RegimeList[RegNum].RegimeDoses[1].AdministrationDays;
                    string strD2 = "";
                    foreach ( int i in RegimeList[RegNum].RegimeDoses[1].AdministrationDays )
                    {
                        strD2 += i + ", ";
                    }
                    //strD2 += "]";
                    tbAdminDays2.Text = strD2;
                    goto case 1;

                case 1:
                    tbDrugName1.Text = RegimeList[RegNum].RegimeDoses[0].DrgName;
                    tbDose1.Text = RegimeList[RegNum].RegimeDoses[0].DrgDose.ToString();
                    cbCalcMethod1.Text = RegimeList[RegNum].RegimeDoses[0].CalcMethod.ToString();
                    cbAdmin1.Text = RegimeList[RegNum].RegimeDoses[0].DrgAdmin;
                    tbURL1.Text = RegimeList[RegNum].RegimeDoses[0].Path;

                    D1Days = RegimeList[RegNum].RegimeDoses[0].AdministrationDays;
                    string strD1 = "";
                    foreach ( int i in RegimeList[RegNum].RegimeDoses[0].AdministrationDays )
                    {
                        strD1 += i + ", ";
                    }
                    // strD1 += "]";
                    tbAdminDays1.Text = strD1;
                    break;
            }
        }

        private void URLlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Hi");
            //UriBuilder EMCurl = new UriBuilder();
            //EMCurl.Host = "www.medicines.org.uk/EMC/medicine";
            //EMCurl.Path = "18609/SPC/Epirubicin+Hydrochloride+2+mg+ml+Injection/";
            SPCviewer SPC = new SPCviewer(EMCurl.Uri);
            SPC.Show();
        }

        private void tbAdminDays1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(sender.ToString());
            // MessageBox.Show(e.ToString());
            AdminDays a = new AdminDays((int) numDaysCycle.Value);
            a.ShowDialog();
            D1Days = a.Days();
            string strOutA = "";
            for ( int i = 0; i < D1Days.Count; i++ )
            {
                strOutA += D1Days[i] + ", ";
            }
            //strOutA += "]";
            tbAdminDays1.Text = strOutA;
        }

        private void tbAdminDays2_Click(object sender, EventArgs e)
        {
            AdminDays b = new AdminDays((int) numDaysCycle.Value);
            b.ShowDialog();
            D2Days = b.Days();
            string strOutB = "";
            for ( int i = 0; i < D2Days.Count; i++ )
            {
                strOutB += D2Days[i] + ", ";
            }
            //strOutB += "]";
            //MessageBox.Show(strOutB);
            tbAdminDays2.Text = strOutB;
        }

        private void tbAdminDays3_Click(object sender, EventArgs e)
        {
            AdminDays c = new AdminDays((int) numDaysCycle.Value);
            c.ShowDialog();
            D3Days = c.Days();
            string strOutC = "";
            for ( int i = 0; i < D3Days.Count; i++ )
            {
                strOutC += D3Days[i] + ", ";
            }
            //strOutC += "]";
            //MessageBox.Show(strOutC);
            tbAdminDays3.Text = strOutC;
        }

        private void tbAdminDays4_Click(object sender, EventArgs e)
        {
            AdminDays d = new AdminDays((int) numDaysCycle.Value);
            d.ShowDialog();
            D4Days = d.Days();
            string strOutD = "";
            for ( int i = 0; i < D4Days.Count; i++ )
            {
                strOutD += D4Days[i] + ", ";
            }
            //strOutD += "]";
            //MessageBox.Show(strOutD);
            tbAdminDays4.Text = strOutD;
        }

        private void RegimesEditor_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(this.Size.Width-10, this.Size.Height - 80);             // Resizes tabcontrol

            int NewHeight = ( tabControl1.Size.Height / 2 ) - 2*tbExtravasation.Size.Height;    // Extract size constant

            tbDesc.Size = new Size(tabControl1.Size.Width-10, NewHeight);                       // Resize description

            tbExtravasation.Location = new Point(0, tbDesc.Size.Height + tbDesc.Location.Y + 5);// Reposition Extravasation

            tbComment.Location = new Point(0, tbExtravasation.Location.Y + tbExtravasation.Size.Height + 5); // Reposition Comment
            tbComment.Size = new Size(tabControl1.Size.Width - 10, NewHeight);                  // Resize Comment
        }
    }
}
