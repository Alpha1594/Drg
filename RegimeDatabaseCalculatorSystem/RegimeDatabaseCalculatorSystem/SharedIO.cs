using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace RegimeDatabaseCalculatorSystem
{
    public class SharedIO
    {
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
        public static List<PatientDataRecords> Patients = new List<PatientDataRecords>();//List of patients

        public List<PatientDataRecords> ReadData()  //Accesses existing patient data from file; Populates List<Paients>
        {
            XmlSerializer XSR = new XmlSerializer(typeof(List<PatientDataRecords>));
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
            }
            return Patients;
        }
    }
}
