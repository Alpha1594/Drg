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
    public partial class PatientData : Form
    {
#region Initialisation
	#region VarDef
	// This section defines global variables and structs and the read/write functions.
        public bool IsNewPatient;
		public int PatientIndex;
        public int MaxDrugIndex; // Highest index used for Regime Doses
        public int RegIndex = -1; // Selected Regime (-1=None)
        public TimeSpan DayOfRegime;


        public struct MedicalValues
        {
            public DateTime LastUpdate;
            public decimal Height;
            public int Weight;
            public int SCreatinine;
            public int AUC;
            public MedicalValues(DateTime LastUpdate, decimal Height, int Weight, int SCreatinine, int AUC)
            {
                this.LastUpdate = LastUpdate;
                this.Height = Height;
                this.Weight = Weight;
                this.SCreatinine = SCreatinine;
                this.AUC = AUC;
            }
        }
        public struct PatientDataRecords    //Defines patient attributes Reffed for access
        {
            public string Name;
            public string PatientNumber;
            public string Consultant;
            public string[] Diagnosis;
            public string Allergies;
            public string ActRegime;
            public string[] Prescription;
            public DateTime DOB;
            public DateTime LastDose;
            public DateTime NextDose;
            public byte CurrentTreatment;
            public byte NoOfTreatments;
            public string Gender;
            public List<MedicalValues> MedVals;
            public PatientDataRecords(string Name, string PatientNumber, string Consultant, string[] Diagnosis, string Allergies, string ActRegime, string[] Prescription, DateTime DOB, DateTime LastDose, DateTime NextDose, byte CurrentTreatment, byte NoOfTreatments, string Gender, MedicalValues LatestMedVal)
            //,  List<
            {
                List<MedicalValues> Placebo = new List<MedicalValues>(); //Creates MedValList
                Placebo.Add(LatestMedVal); //Takes LatestMedVal adds it to list
                this.Name = Name;
                this.PatientNumber = PatientNumber;
                this.Consultant = Consultant;
                this.Diagnosis = Diagnosis;
                this.Allergies = Allergies;
                this.ActRegime = ActRegime;
                this.Prescription = Prescription;
                this.DOB = DOB;
                this.LastDose = LastDose;
                this.NextDose = NextDose;
                this.CurrentTreatment = CurrentTreatment;
                this.NoOfTreatments = NoOfTreatments;
                this.Gender = Gender;
                this.MedVals = Placebo;     //Using above to to add data sans tantrum
            }
        }
        public static List<PatientDataRecords> Patients = new List<PatientDataRecords>();//List of patients

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
	#endregion

        public PatientData(bool New, string SearchedName)       //Generates & Configures Form <New>|<Existing> Patient
        {  
            InitializeComponent();
            GetRegList();
            if (New == true) //New patient
            {
                tbName.Text = SearchedName; //Name in Regime Search box used as New Patient name
                btnSubmit.Enabled = true;   //Form has btnSubmit
                btnSubmit.Visible = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                IsNewPatient = true;
            }
            else //Updating Current Patient
            {
                PatientIndex = int.Parse(SearchedName); // Int cast to string for polymorphic reasons
                PopulatePatientData(PatientIndex); //Populates form for patient selected from Regime 
                btnSubmit.Enabled = false;  //Form has btnUpdate
                btnSubmit.Visible = false;
                btnUpdate.Enabled = true;
                btnUpdate.Visible = true;
                IsNewPatient = false;
            }
         }

	#region IOfuncDef
		// This section defines the read/write functions.
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

        public void GetRegList()
        {
            RegimeList.Clear();
            cbActRegime.Items.Clear();
            ReadRegimes();
            foreach ( RegimeData RD in RegimeList )
            {
                cbActRegime.Items.Add(RD.RegName);
            }
        }

        public void ReadData()  //Accesses existing patient data from file; Populates List<Patients>
        {
            XmlSerializer XSR = new XmlSerializer(typeof(List<PatientDataRecords>));
            if (File.Exists("PatientRecords.xml"))
            {
                FileStream XFile = new FileStream("PatientRecords.xml", FileMode.Open);
                if ( XFile.Length > 0 )
                {
                    Patients = (List<PatientDataRecords>) XSR.Deserialize(XFile);
                }
                XFile.Close();
            }
            else
            {
                FileStream XFile = new FileStream("PatientRecords.xml", FileMode.CreateNew);
                XFile.Close();
            }
         }
	#endregion
#endregion

        private void btnSubmit_Click(object sender, EventArgs e) //Submit New Record
        {
            ReadData();         //Populates List<Patient> with existing data
            MedicalValues LMV = new MedicalValues(DateTime.Now.Date,//Last update DateTime<>
                numHeight.Value,//decimal
                Convert.ToInt32(numWeight.Value),//Int
                (int) numSC.Value,  //int
                (int) numAUC.Value
            );
            //New instance of PatientDataRecords Populated with current patients info
            PatientDataRecords X = new PatientDataRecords(
                    tbName.Text, //str
                    tbPatNum.Text,
                    cbConsultant.Text,//str
                    tbDiagnosis.Lines,
                    tbAllergies.Text,//str
                    cbActRegime.Text,
                    tbPrescriptions.Lines,
                    DateTime.Parse(dtDOB.Text),//DateTime
                    DateTime.Parse(dtLastDose.Text),//DateTime
                    DateTime.Parse(dtNextDose.Text),//DateTime
                    byte.Parse(numCurrentTreatment.Value.ToString()),//Byte
                    byte.Parse(numNoOfTreatments.Value.ToString()),//Byte
                    cbGender.Text,//Str
                    LMV
                    );
            XmlSerializer XSR = new XmlSerializer(typeof(List<PatientDataRecords>));	//new instance of XML serialiser to store List PatientDataRecords
            Patients.Add(X);	//Appends latest data to list
            FileStream DataOut = new FileStream("PatientRecords.xml", FileMode.Create);	//Creates file object
            XSR.Serialize(DataOut, Patients);   //Outputs data
            DataOut.Close();	//Closes File
            MessageBox.Show("Data Recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

#region Existing Patient
        // Functions for existing patients
    #region Read/Write
        private void PopulatePatientData(int lIndex) // Loads an existing patients data
        {
            ReadData();
            numIndex.Value = lIndex;     //PatientIndex recorded in invisible numbox so accessible to Update function 
            tbName.Text = Patients[lIndex].Name;
            tbPatNum.Text = Patients[lIndex].PatientNumber;
            cbConsultant.Text = Patients[lIndex].Consultant;
            tbDiagnosis.Lines = Patients[lIndex].Diagnosis;
            tbAllergies.Text = Patients[lIndex].Allergies;
            cbActRegime.Text = Patients[lIndex].ActRegime;
            tbPrescriptions.Lines = Patients[lIndex].Prescription;
            dtLastDose.Value = Patients[lIndex].LastDose;
            dtNextDose.Value = Patients[lIndex].NextDose;
            numCurrentTreatment.Value = Patients[lIndex].CurrentTreatment;
            numNoOfTreatments.Value = Patients[lIndex].NoOfTreatments;
            dtDOB.Value = Patients[lIndex].DOB;
            cbGender.Text = Patients[lIndex].Gender;

            int iMax = Patients[lIndex].MedVals.Count();
            numWeight.Value = Patients[lIndex].MedVals[iMax - 1].Weight;
            numSC.Value = Patients[lIndex].MedVals[iMax - 1].SCreatinine;  //int
            numHeight.Value = Patients[lIndex].MedVals[iMax - 1].Height;
            numAUC.Value = Patients[lIndex].MedVals[iMax - 1].AUC;

            //Populate Calendar
            List<DateTime> Readings = new List<DateTime>();
            foreach ( MedicalValues MV in Patients[lIndex].MedVals )
            {
                Readings.Add(MV.LastUpdate);
            }
            calDataUpdate.BoldedDates = Readings.ToArray();

    #region RegimeInfoPopulation
            int i = 0;  // Local Stepper varaible
            foreach ( RegimeData RD in RegimeList ) // Used to set the RegIndex
            {
                if ( RD.RegName == cbActRegime.Text )
                {
                    RegIndex = i;
                    break;
                }
                else
                    ++i;
            }

            if (RegIndex != -1)
            {
                MaxDrugIndex = RegimeList[RegIndex].RegimeDoses.Count;
                switch ( MaxDrugIndex )
                {
                    case 4:     
                        llblDrgName4.Text = RegimeList[RegIndex].RegimeDoses[3].DrgName;
                        lblDrgDose4.Text = RegimeList[RegIndex].RegimeDoses[3].DrgDose.ToString();
                        lblCalcMethod4.Text = RegimeList[RegIndex].RegimeDoses[3].CalcMethod;
                        goto case 3;

                    case 3:
                        llblDrgName3.Text = RegimeList[RegIndex].RegimeDoses[2].DrgName;
                        lblDrgDose3.Text = RegimeList[RegIndex].RegimeDoses[2].DrgDose.ToString();
                        lblCalcMethod3.Text = RegimeList[RegIndex].RegimeDoses[2].CalcMethod;
                        goto case 2;

                    case 2:
                        llblDrgName2.Text = RegimeList[RegIndex].RegimeDoses[1].DrgName;
                        lblDrgDose2.Text = RegimeList[RegIndex].RegimeDoses[1].DrgDose.ToString();
                        lblCalcMethod2.Text = RegimeList[RegIndex].RegimeDoses[1].CalcMethod;
                        goto case 1;

                    case 1:
                        llblDrgName1.Text = RegimeList[RegIndex].RegimeDoses[0].DrgName;
                        lblDrgDose1.Text = RegimeList[RegIndex].RegimeDoses[0].DrgDose.ToString();
                        lblCalcMethod1.Text = RegimeList[RegIndex].RegimeDoses[0].CalcMethod;
                        break;

                    default:
                                MessageBox.Show("You done goofed");
                        break;
                }
                DrgVisibilityToggle(MaxDrugIndex);
                MessageBox.Show("Testing administerability");
                DayToAdminister(MaxDrugIndex);
            }
            else
            {
                MessageBox.Show("This patient isn't on a Regime");
            }

            //DayOfRegime = DateTime.Today.Date - Patients[lIndex].MedVals[0].LastUpdate.Date;
            lblDayOfRegime.Text = DayOfRegime.TotalDays.ToString();
            int LocalDaysPerReg = (int) DayOfRegime.TotalDays;
            while ( (int) LocalDaysPerReg > RegimeList[RegIndex].DaysPerCycle )
            {
                if ( numNoOfTreatments.Value <= RegimeList[RegIndex].NoOfCycles )
                {
                    LocalDaysPerReg -= RegimeList[RegIndex].DaysPerCycle;
                    numCurrentTreatment.Value++;
                }
                else
                {
                    MessageBox.Show("The prescribed Regime has finished");
                    break;
                }
            }
            numCurrentTreatment.Value = LocalDaysPerReg;

    #endregion

            #region Modifiers
            fullEditModeToolStripMenuItem.Visible = true;
            fullEditModeToolStripMenuItem.Enabled = true;
            tbName.Enabled = false;
            tbPatNum.Enabled = false;
            cbGender.Enabled = false;
            dtDOB.Enabled = false;
            #endregion
        }


        private void btnUpdate_Click(object sender, EventArgs e) // Updates Existing patient
        {
            PatientIndex = (int) numIndex.Value;       //Takes index value from invisible numbox (tab2)
            /* int index = (int) numIndex.Value;       //Takes index value from invisible numbox (tab2) */
            PatientDataRecords a = Patients[PatientIndex]; //Value @ list[index] copied to new instance of PatientDataRecords
            Patients.RemoveAt(PatientIndex);               //Old instance removed from list
            a.Name = tbName.Text;                   //Populate a
            a.PatientNumber = tbPatNum.Text;
            a.Consultant = cbConsultant.Text;
            a.Diagnosis = tbDiagnosis.Lines;
            a.Allergies = tbAllergies.Text;
            a.ActRegime = cbActRegime.Text;
            a.Prescription = tbPrescriptions.Lines;
            a.LastDose = dtLastDose.Value;
            a.NextDose = dtNextDose.Value;
            a.CurrentTreatment = (byte)numCurrentTreatment.Value;
            a.NoOfTreatments = (byte) Convert.ToInt32(numNoOfTreatments.Value.ToString());
            a.DOB = dtDOB.Value;
            a.Gender = cbGender.Text;

            MedicalValues LMV = new MedicalValues(DateTime.Now.Date,//Last update DateTime<>
                numHeight.Value,//decimal
                Convert.ToInt32(numWeight.Value),//Int
                (int) numSC.Value,  //int
                (int) numAUC.Value
            );
            a.MedVals.Add(LMV);
            Patients.Add(a);                        //Append updates from a to list

            XmlSerializer XSR = new XmlSerializer(typeof(List<PatientDataRecords>));	//new instance of XML serialiser to store List PatientDataRecords
            FileStream DataOut = new FileStream("PatientRecords.xml", FileMode.Create);	//Creates file object
            XSR.Serialize(DataOut, Patients);   //Outputs data
            DataOut.Close();	//Closes File
            MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void calDataUpdate_DateSelected(object sender, DateRangeEventArgs e) // Shows reading for clicked day
        {
            PatientIndex = (int) numIndex.Value;                   //Current Index
            /* int index = (int) numIndex.Value;                   //Current Index */
            DateTime Selected = calDataUpdate.SelectionStart;   //Clicked Cal Value

            List<MedicalValues> MedValEntries = Patients[PatientIndex].MedVals.ToList();   //List of MedVal Updates for current patient
            foreach ( MedicalValues MV in MedValEntries )
            {
                if ( MV.LastUpdate == Selected )
                {
                    numHeight.Value = MV.Height;
                    numWeight.Value = MV.Weight;
                    numSC.Value = MV.SCreatinine;
                }
            }
            DoTheCalculations();
        }
    #endregion


        public void DrgVisibilityToggle(int MaxIndex) // Hides unused fields (For regimes with < 4 drugs)
        {
            switch (MaxIndex)
            {
                case 1:
                    llblDrgName2.Visible = false;
                    lblCalcMethod2.Visible = false;
                    lblDrgDose2.Visible = false;
                    tbCalcDose2.Visible = false;
                    goto case 2;

                case 2:
                    llblDrgName3.Visible = false;
                    lblCalcMethod3.Visible = false;
                    lblDrgDose3.Visible = false;
                    tbCalcDose3.Visible = false;
                    goto case 3;

                case 3:
                    llblDrgName4.Visible = false;
                    lblCalcMethod4.Visible = false;
                    lblDrgDose4.Visible = false;
                    tbCalcDose4.Visible = false;
                break;
            }
        }


        public bool ToGive(int lDrugIndex) // Function to determine if a drug should be administered on this day
        {
            bool give = false;
            List<int> curDrug = RegimeList[RegIndex].RegimeDoses[lDrugIndex].AdministrationDays;
            DayOfRegime = DateTime.Today.Date - Patients[PatientIndex].MedVals[0].LastUpdate.Date;
            int Today = DayOfRegime.Days;
            foreach ( int i in curDrug )
            {
                // MessageBox.Show("Today "+Today.ToString() +"\n i=" + i.ToString());
                if ( i == Today )
                    give = true;
            }
            MessageBox.Show(give.ToString());
            return give;
        }


        public void DayToAdminister(int MaxIndex) // Hides non applicable regime components (Dependency: ToGive)
        {
            switch ( MaxIndex-1 )
            {
                case 3:
                    if ( !ToGive(3) )
                    {
                        llblDrgName4.Visible = false;
                        lblCalcMethod4.Visible = false;
                        lblDrgDose4.Visible = false;
                        tbCalcDose4.Visible = false;
                    }
                    goto case 2;
                case 2:
                    if ( !ToGive(2) )
                    {
                        llblDrgName3.Visible = false;
                        lblCalcMethod3.Visible = false;
                        lblDrgDose3.Visible = false;
                        tbCalcDose3.Visible = false;
                    }
                    goto case 1;
                case 1:
                    if ( !ToGive(1) )
                    {
                        llblDrgName2.Visible = false;
                        lblCalcMethod2.Visible = false;
                        lblDrgDose2.Visible = false;
                        tbCalcDose2.Visible = false;
                    }
                    goto case 0;
                case 0:
                    if ( !ToGive(0) )
                    {
                        llblDrgName1.Visible = false;
                        lblCalcMethod1.Visible = false;
                        lblDrgDose1.Visible = false;
                        tbCalcDose1.Visible = false;
                    }
                    break;
            }
        }

#endregion

#region TabControl
        private void btnNext_Click(object sender, EventArgs e) //Moves to next tab
        {
            ++tabPatientData.SelectedIndex;
        }

        private void btnNextEnableCheck_Click(object sender, EventArgs e) //Determines btnNext visibility
        {
            if ( tabPatientData.SelectedIndex == 3 )
                {
                    btnNext.Visible = false;
                    btnNext.Enabled = false;
                    DoTheCalculations();
                }
                else
                {
                    btnNext.Visible = true;
                    btnNext.Enabled = true;
                }
        }
#endregion

        private void btnReset_Click(object sender, EventArgs e) // Resets the form fields
        {
            if ( IsNewPatient == true ) // Clears all fields for unsaved patients.
            {
                TextBox[] TB = { tbName, tbPatNum, tbDiagnosis,tbPrescriptions, tbAllergies };
                foreach ( TextBox X in TB )
                {
                    X.Clear();
                }

                ComboBox[] CB = { cbConsultant, cbGender };
                foreach ( ComboBox Y in CB )
                {
                    Y.ResetText();
                }

                NumericUpDown[] NU = { numCurrentTreatment, numNoOfTreatments, numHeight, numWeight, numSC };
                foreach ( NumericUpDown Z in NU )
                {
                    Z.ResetText();
                }

                DateTimePicker[] DT = { dtLastDose, dtNextDose, dtDOB, };
                foreach ( DateTimePicker W in DT )
                {
                    W.ResetText();
                }
            }
            else // restores last saved data
            {
                DialogResult qReset = MessageBox.Show("This will reset the form to the last saved results.\nDo you wish to proceed?", "Confirm Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ( qReset.Equals(DialogResult.OK) )
                    PopulatePatientData(PatientIndex); // Repopulates form for current patient using last saved data.
                else
                    MessageBox.Show("Reset Canceled");
            }
        }

#region Menus
// Menu bar event handlers
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

        private void fullEditModeToolStripMenuItem_Click(object sender, EventArgs e) //Allows all fields to be edited
        {
            tbName.Enabled = !tbName.Enabled;
            tbPatNum.Enabled = !tbPatNum.Enabled;
            cbGender.Enabled = !cbGender.Enabled;
            dtDOB.Enabled = !dtDOB.Enabled;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"User.pdf");
        }
#endregion

        public void DoTheCalculations() // Performs the initial calculations (BSA, eGFR & Calvert)
        {
            #region BSA
            tbBSA.BackColor = Color.White; //Resets tb bg Color.
            double Weight = (double) numWeight.Value;
            double Height = (double) numHeight.Value;
            cBSA currentBSA = new cBSA();
            double ans = Math.Round(currentBSA.BSA(Height, Weight), 1);
            if ( ans > 2 )  //Validation to prevent high doses BSA usually has a ceiling of 2.
            {
                string txtOut = "BSA is: " + ans.ToString() + "\nPlease discuss with the Consultant before using values greater than 2 in dosage calculations.\nPress OK accept a BSA value of 2 or Cancel to continue with existing value.";
                DialogResult choice = MessageBox.Show(txtOut, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if ( choice == DialogResult.OK )
                    ans = 2.0;
                else
                    tbBSA.BackColor = Color.Red;
            }
            tbBSA.Text = ans.ToString();//            +" m^2";
            #endregion
            #region eGFR
            int age = (int) DateTime.Now.Year - dtDOB.Value.Year;
            double Mass = (double) numWeight.Value;
            double SCreat = (double) numSC.Value;
            string g;
            if ( cbGender.Text == "Male" )
                g = "M";
            else
                g = "F";
            cCCr currentCCR = new cCCr();
            double cAns = currentCCR.CCR(age, Mass, SCreat, g);
            tbGFR.Text = Math.Round(cAns, 0).ToString(); //+ " ml/min";
            #endregion
            #region Calvert
            int auc = (int) numAUC.Value;
            int gfr = (int) cAns;
            cCalvert currentCalvert = new cCalvert();
            int caAns = currentCalvert.Calvert(auc, gfr);
            tbCa.Text = caAns.ToString();
            #endregion
            DisplayDoses();
        }

        public void DetermineDoses(int DosageIndex)
        {
            TextBox[] TBarray = { tbCalcDose1, tbCalcDose2, tbCalcDose3, tbCalcDose4 };
            Label[] DrgDoseList = { lblDrgDose1, lblDrgDose2, lblDrgDose3, lblDrgDose4 };
            if ( DrgDoseList[DosageIndex].Text == "AUC" )
                TBarray[DosageIndex].Text = tbCa.Text;
            else
                TBarray[DosageIndex].Text = ( double.Parse(DrgDoseList[DosageIndex].Text) * double.Parse(tbBSA.Text) ).ToString();
        }

        public void DisplayDoses() // Uses the intial calculations to get the dosage
        {
            MaxDrugIndex = RegimeList[RegIndex].RegimeDoses.Count;
            switch ( MaxDrugIndex )
            {
                case 4:
                    DetermineDoses(3);
                        goto case 3;

                case 3: 
                    DetermineDoses(2);
                        goto case 2;

                case 2:
                    DetermineDoses(1);
                        goto case 1;

                case 1:
                    DetermineDoses(0);
                        break;
                default:
                        // MessageBox.Show("You done goofed");
                        break;
                }

        }

        private void btnCalc_Click(object sender, EventArgs e) //Inline Calculations
        {
            DoTheCalculations();
            if ( sender.ToString().Contains("Calc") )
                tabPatientData.SelectedIndex = 3;
        }

        #region SPCViewer
        private void RegViewer(int index)
        {
            UriBuilder EMCurl = new UriBuilder();
            EMCurl.Host = "www.medicines.org.uk/EMC/medicine";
            EMCurl.Path = RegimeList[RegIndex].RegimeDoses[index].Path;

            SPCviewer SPC = new SPCviewer(EMCurl.Uri);
            SPC.Show();
        }

        private void llblDrgName1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegViewer(0);
        }

        private void llblDrgName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegViewer(1);
        }

        private void llblDrgName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegViewer(2);
        }

        private void llblDrgName4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegViewer(3);
        }
        #endregion

        private void btnSelectRegime_Click(object sender, EventArgs e)
        {
            RegIndex = cbActRegime.Items.IndexOf(cbActRegime.Text);
            // MessageBox.Show(RegIndex.ToString());
            GetRegList();
            numCurrentTreatment.Value = 0;
            // MessageBox.Show(RegimeList.Count.ToString());
            numNoOfTreatments.Value = RegimeList[RegIndex].NoOfCycles;
            // MessageBox.Show(RegimeList[RegIndex].NoOfCycles.ToString());
        }
    }
}
