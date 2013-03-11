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
    public partial class RegimeViewer : Form
    {
        public RegimeViewer()
        {
            InitializeComponent();
            LoadRegimeList();
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

        #region RegimeViewer
        public void LoadRegimeList()
        {
            listRegimes.Items.Clear(); //Blanks GUI list
            RegimeList.Clear(); //Clears internal list
            ReadRegimes();
            foreach ( RegimeData X in RegimeList )
            {
                listRegimes.Items.Add(X.RegName);
            }
        }
        #endregion

        private void listRegimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ChosenRegime;
            ChosenRegime = listRegimes.SelectedIndex;
            RegimesEditor RE = new RegimesEditor(ChosenRegime, false);
            RE.Show();
        }

        private void btnNewReg_Click(object sender, EventArgs e)
        {
            RegimesEditor RE = new RegimesEditor(0, true);
            RE.Show();
        }

        private void RegimeViewer_Activated(object sender, EventArgs e)
        {
            LoadRegimeList();
        }

        private void RegimeViewer_SizeChanged(object sender, EventArgs e)
        {
            listRegimes.Size = new Size(this.Size.Width, this.Size.Height - 50);
        }
    }
}
