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
    public partial class Regime : Form
    {
#region Initialisation
        public Regime()     //Generates Form; Populates List.
        {
            InitializeComponent();
            LoadPatientList();
            LoadRegimeList();
        }
        
        public struct MedicalValues         //Defines patients Medical atributes Reffed for access
        {
            public DateTime LastUpdate;
            public decimal Height;
            public int Weight;
            public int SCreatinine;
            public MedicalValues(DateTime LastUpdate, decimal Height, int Weight, int SCreatinine)
            {
                this.LastUpdate = LastUpdate;
                this.Height = Height;
                this.Weight = Weight;
                this.SCreatinine = SCreatinine;
            }
        }
        public struct PatientDataRecords    //Defines patient atributes Reffed for access
        {
            public string Name;
            public string PatientNumber;
            public string Consultant;
            //public List<string> Diagnosis;
            public string Allergies;
            public string ActRegime;
            //public List<string> Prescription;
            public DateTime DOB;
            public DateTime LastDose;
            public DateTime NextDose;
            public byte DoseSchedule;
            public byte CurrentTreatment;
            public byte NoOfTreatments;
            public string Gender;
            public List<MedicalValues> MedVals;
            public PatientDataRecords(string Name, string PatientNumber, string Consultant, string Allergies, string ActRegime, DateTime DOB, DateTime LastDose, DateTime NextDose, byte DoseSchedule, byte CurrentTreatment, byte NoOfTreatments, string Gender, MedicalValues LatestMedVal)
            //List<string> Diagnosis,  List<string> Prescription,
            {
                List<MedicalValues> Placebo = new List<MedicalValues>(); //Creates MedValList
                Placebo.Add(LatestMedVal); //Takes LatestMedVal adds it to list
                this.Name = Name;
                this.PatientNumber = PatientNumber;
                this.Consultant = Consultant;
                //this.Diagnosis = Diagnosis;
                this.Allergies = Allergies;
                this.ActRegime = ActRegime;
                //this.Prescription = Prescription;
                this.DOB = DOB;
                this.LastDose = LastDose;
                this.NextDose = NextDose;
                this.DoseSchedule = DoseSchedule;
                this.CurrentTreatment = CurrentTreatment;
                this.NoOfTreatments = NoOfTreatments;
                this.Gender = Gender;
                //this.MedVal.LastUpdate = LastUpdate;
                this.MedVals = Placebo;     //Using above to to add data sans tantrum
                //this.MedVals.Insert(0,LatestMedVal);
                //this.MedVal.Height = Height;
                //this.MedVal.Weight = Weight;
                //this.MedVal.SCreatinine = SCreatinine;
            }
        }
        public static List<PatientDataRecords> Patients = new List<PatientDataRecords>();//List of all patients

        public struct PatientList           //Local list to open the required record in PatientData file
        {
            public string Name;
            public string PatientNumber;
            public int index;
            public PatientList(string Name, string PatientNumber, int index)
            {
                this.Name = Name;
                this.PatientNumber = PatientNumber;
                this.index = index;
            }
        }       
        public static List<PatientList> SubPatients = new List<PatientList>();    //Filtered List of patients
        public void ReadData()      //Populates Patients =List<PatientDataRecords>
        {
            XmlSerializer XSR = new XmlSerializer(typeof(List<PatientDataRecords>));
            PopulateList:
            if ( File.Exists("PatientRecords.xml") )
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
                goto PopulateList;
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
            public string Desc;
            public string Extravasation;
            public string Comments;
            public List<Doses> RegimeDoses;
            public int NoOfCycles;
            public int DaysPerCycle;
            public RegimeData(string RegName, string Desc, string Extravasation, string Comments, List<Doses> LatestDose, int NoOfCycles, int DaysPerCycle)// 
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
#endregion
        
#region Load/Search PatientList
        public void LoadPatientList()
        {
            listPatients.Items.Clear(); //Blanks GUI list
            SubPatients.Clear(); //Clears internal list
            ReadData();
            int count = 0;
            foreach ( PatientDataRecords X in Patients )
            {
                PatientList append = new PatientList();
                append.Name = X.Name;
                append.PatientNumber = X.PatientNumber;
                append.index = count;
                SubPatients.Add(append);                
                listPatients.Items.Add(append.Name);
                count++;
            }
            if ( tbSearchName.Text.Length != 0 )    //Search Function
            {
                string SearchTerm = tbSearchName.Text;  //RegEx Query

                if (SearchTerm.Contains("\\") | SearchTerm.Contains("[") | SearchTerm.Contains("]"))
                {
                    return;
                }
                listPatients.Items.Clear(); //Clears FormList
                SubPatients.Clear();
                int Count = 0;
                foreach ( PatientDataRecords P in Patients ) //Populates SubPatients with terms that match the Query
                {
                    if ( System.Text.RegularExpressions.Regex.IsMatch(P.Name, SearchTerm, System.Text.RegularExpressions.RegexOptions.IgnoreCase) )
                    {
                        PatientList append = new PatientList();
                        append.Name = P.Name;
                        append.PatientNumber = P.PatientNumber;
                        append.index = Count;
                        SubPatients.Add(append);
                        listPatients.Items.Add(append.Name);
                    }
                    Count++;
                }
            }
            if (listRegimes.SelectedIndex != -1)
            {
                listPatients.Items.Clear(); //Clears FormList
                SubPatients.Clear();
                int Count = 0;
                foreach (PatientDataRecords P in Patients)
                {
                    if (P.ActRegime == RegimeList[listRegimes.SelectedIndex].RegName)
                    {
                        PatientList append = new PatientList();
                        append.Name = P.Name;
                        append.PatientNumber = P.PatientNumber;
                        append.index = Count;
                        SubPatients.Add(append);
                        listPatients.Items.Add(append.Name);
                    }
                    Count++;
                }
            }
        }
    #region EventHandlers for LoadPatientList();
            private void btnSearch_Click_1(object sender, EventArgs e)
                //Refreshes PatientList & Shows searched patients when btnSearch Pressed
            {
                LoadPatientList();
            }

            private void tbSearchName_TextChanged_1(object sender, EventArgs e)
                //Refreshes PatientList & Shows searched patients when Search tb content changed
            {
                LoadPatientList();
            }

            private void Regime_Activated(object sender, EventArgs e)
                //Refreshes PatientList & Shows searched patients when form activated
            {
                LoadPatientList();
            }
    #endregion
#endregion

#region RegimeViewer
        public void LoadRegimeList()
        {
            listRegimes.Items.Clear(); //Blanks GUI list
            RegimeList.Clear(); //Clears internal list
            ReadRegimes();
            foreach ( RegimeData X in RegimeList )
            {
                //MessageBox.Show(X.RegName);
                listRegimes.Items.Add(X.RegName);
            }
        }
#endregion

#region Form PatientData Callers
        private void btnNP_Click(object sender, EventArgs e) //Opens Form to enter data for a new patient 
        {
            PatientData pData = new PatientData(true,tbSearchName.Text);
            pData.Show();
        }
#region ExistingPatient
        private void ExistingPatient() //Opens form to update the patients records
        {
            int ChosenPatient = SubPatients[listPatients.SelectedIndex].index;
            //MessageBox.Show(listPatients.SelectedIndex.ToString());
            if ( ChosenPatient == -1 )
            {
                MessageBox.Show("You have not selected a patient", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PatientData pData = new PatientData(false, ChosenPatient.ToString());
                pData.Show();
            }
        }

        #region EventHandlers for ExistingPatient();
        private void btnSubmit_Click(object sender, EventArgs e) //ExistingPatient btnSubmit
        {
            ExistingPatient();
        }

        private void listPatients_DoubleClick(object sender, EventArgs e) //ExistingPatient Doubleclick on list
        {
            ExistingPatient();
        }
        
        private void listPatients_KeyPress(object sender, KeyPressEventArgs e)
        {
            ExistingPatient();
        }
        #endregion
#endregion  
#endregion

        private void listRegimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatientList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listRegimes.SelectedIndex = -1;
        }

    }
}
