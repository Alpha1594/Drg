namespace RegimeDatabaseCalculatorSystem
{
    partial class Calculators
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculators));
            this.tabCalculators = new System.Windows.Forms.TabControl();
            this.tBSA = new System.Windows.Forms.TabPage();
            this.btnBSA = new System.Windows.Forms.Button();
            this.tbBSA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tCG = new System.Windows.Forms.TabPage();
            this.btnUse4Calvert = new System.Windows.Forms.Button();
            this.bnteCCR = new System.Windows.Forms.Button();
            this.tbCCr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.tbSC = new System.Windows.Forms.TextBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tCalvert = new System.Windows.Forms.TabPage();
            this.btnGetEccr = new System.Windows.Forms.Button();
            this.btnCa = new System.Windows.Forms.Button();
            this.tbDose = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGFR = new System.Windows.Forms.TextBox();
            this.tbAUC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCalculators.SuspendLayout();
            this.tBSA.SuspendLayout();
            this.tCG.SuspendLayout();
            this.tCalvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCalculators
            // 
            this.tabCalculators.Controls.Add(this.tBSA);
            this.tabCalculators.Controls.Add(this.tCG);
            this.tabCalculators.Controls.Add(this.tCalvert);
            this.tabCalculators.Location = new System.Drawing.Point(0, 0);
            this.tabCalculators.Name = "tabCalculators";
            this.tabCalculators.SelectedIndex = 0;
            this.tabCalculators.ShowToolTips = true;
            this.tabCalculators.Size = new System.Drawing.Size(297, 230);
            this.tabCalculators.TabIndex = 0;
            // 
            // tBSA
            // 
            this.tBSA.Controls.Add(this.btnBSA);
            this.tBSA.Controls.Add(this.tbBSA);
            this.tBSA.Controls.Add(this.label3);
            this.tBSA.Controls.Add(this.tbWeight);
            this.tBSA.Controls.Add(this.tbHeight);
            this.tBSA.Controls.Add(this.label2);
            this.tBSA.Controls.Add(this.label1);
            this.tBSA.Location = new System.Drawing.Point(4, 22);
            this.tBSA.Name = "tBSA";
            this.tBSA.Padding = new System.Windows.Forms.Padding(3);
            this.tBSA.Size = new System.Drawing.Size(289, 204);
            this.tBSA.TabIndex = 0;
            this.tBSA.Text = "BSA";
            this.tBSA.ToolTipText = "Body Surface Area";
            this.tBSA.UseVisualStyleBackColor = true;
            // 
            // btnBSA
            // 
            this.btnBSA.Location = new System.Drawing.Point(176, 173);
            this.btnBSA.Name = "btnBSA";
            this.btnBSA.Size = new System.Drawing.Size(100, 25);
            this.btnBSA.TabIndex = 6;
            this.btnBSA.Text = "Calculate BSA";
            this.btnBSA.UseVisualStyleBackColor = true;
            this.btnBSA.Click += new System.EventHandler(this.btnBSA_Click);
            // 
            // tbBSA
            // 
            this.tbBSA.Location = new System.Drawing.Point(176, 93);
            this.tbBSA.Name = "tbBSA";
            this.tbBSA.Size = new System.Drawing.Size(100, 20);
            this.tbBSA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BSA [m²]";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(176, 51);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(176, 28);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight [Kg]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height [m]";
            // 
            // tCG
            // 
            this.tCG.Controls.Add(this.btnUse4Calvert);
            this.tCG.Controls.Add(this.bnteCCR);
            this.tCG.Controls.Add(this.tbCCr);
            this.tCG.Controls.Add(this.label7);
            this.tCG.Controls.Add(this.cbGender);
            this.tCG.Controls.Add(this.tbSC);
            this.tCG.Controls.Add(this.tbMass);
            this.tCG.Controls.Add(this.tbAge);
            this.tCG.Controls.Add(this.label6);
            this.tCG.Controls.Add(this.label5);
            this.tCG.Controls.Add(this.label4);
            this.tCG.Location = new System.Drawing.Point(4, 22);
            this.tCG.Name = "tCG";
            this.tCG.Padding = new System.Windows.Forms.Padding(3);
            this.tCG.Size = new System.Drawing.Size(289, 204);
            this.tCG.TabIndex = 1;
            this.tCG.Text = "Cockcroft-Gault";
            this.tCG.ToolTipText = "Estimated Creatinine Clearance Rate (eCCR)";
            this.tCG.UseVisualStyleBackColor = true;
            // 
            // btnUse4Calvert
            // 
            this.btnUse4Calvert.Enabled = false;
            this.btnUse4Calvert.Location = new System.Drawing.Point(162, 177);
            this.btnUse4Calvert.Name = "btnUse4Calvert";
            this.btnUse4Calvert.Size = new System.Drawing.Size(114, 23);
            this.btnUse4Calvert.TabIndex = 10;
            this.btnUse4Calvert.Text = "&Use result for Calvert";
            this.btnUse4Calvert.UseVisualStyleBackColor = true;
            this.btnUse4Calvert.Visible = false;
            this.btnUse4Calvert.Click += new System.EventHandler(this.TabSwitcher_Click);
            // 
            // bnteCCR
            // 
            this.bnteCCR.Location = new System.Drawing.Point(176, 150);
            this.bnteCCR.Name = "bnteCCR";
            this.bnteCCR.Size = new System.Drawing.Size(100, 23);
            this.bnteCCR.TabIndex = 9;
            this.bnteCCR.Text = "&Calculate eCCR";
            this.bnteCCR.UseVisualStyleBackColor = true;
            this.bnteCCR.Click += new System.EventHandler(this.btneCCR_Click);
            // 
            // tbCCr
            // 
            this.tbCCr.Location = new System.Drawing.Point(176, 114);
            this.tbCCr.Name = "tbCCr";
            this.tbCCr.Size = new System.Drawing.Size(100, 20);
            this.tbCCr.TabIndex = 8;
            this.tbCCr.TextChanged += new System.EventHandler(this.tbCCr_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Creatinine Clearance Rate [ml/min]";
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(176, 85);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(49, 17);
            this.cbGender.TabIndex = 6;
            this.cbGender.Text = "Male";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // tbSC
            // 
            this.tbSC.Location = new System.Drawing.Point(176, 59);
            this.tbSC.Name = "tbSC";
            this.tbSC.Size = new System.Drawing.Size(100, 20);
            this.tbSC.TabIndex = 5;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(176, 37);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(100, 20);
            this.tbMass.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(176, 14);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Serum Creatinine [μmol/L]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mass [Kg]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age";
            // 
            // tCalvert
            // 
            this.tCalvert.Controls.Add(this.btnGetEccr);
            this.tCalvert.Controls.Add(this.btnCa);
            this.tCalvert.Controls.Add(this.tbDose);
            this.tCalvert.Controls.Add(this.label10);
            this.tCalvert.Controls.Add(this.tbGFR);
            this.tCalvert.Controls.Add(this.tbAUC);
            this.tCalvert.Controls.Add(this.label9);
            this.tCalvert.Controls.Add(this.label8);
            this.tCalvert.Location = new System.Drawing.Point(4, 22);
            this.tCalvert.Name = "tCalvert";
            this.tCalvert.Size = new System.Drawing.Size(289, 204);
            this.tCalvert.TabIndex = 2;
            this.tCalvert.Text = "Calvert";
            this.tCalvert.ToolTipText = "Determines dose based on eCCR";
            this.tCalvert.UseVisualStyleBackColor = true;
            // 
            // btnGetEccr
            // 
            this.btnGetEccr.Location = new System.Drawing.Point(176, 159);
            this.btnGetEccr.Name = "btnGetEccr";
            this.btnGetEccr.Size = new System.Drawing.Size(100, 23);
            this.btnGetEccr.TabIndex = 7;
            this.btnGetEccr.Text = "Get CCR";
            this.btnGetEccr.UseVisualStyleBackColor = true;
            this.btnGetEccr.Click += new System.EventHandler(this.TabSwitcher_Click);
            // 
            // btnCa
            // 
            this.btnCa.Location = new System.Drawing.Point(176, 130);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(100, 23);
            this.btnCa.TabIndex = 6;
            this.btnCa.Text = "Calculate Dose";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // tbDose
            // 
            this.tbDose.Location = new System.Drawing.Point(176, 83);
            this.tbDose.Name = "tbDose";
            this.tbDose.Size = new System.Drawing.Size(100, 20);
            this.tbDose.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dose [mg]";
            // 
            // tbGFR
            // 
            this.tbGFR.Location = new System.Drawing.Point(176, 38);
            this.tbGFR.Name = "tbGFR";
            this.tbGFR.Size = new System.Drawing.Size(100, 20);
            this.tbGFR.TabIndex = 3;
            // 
            // tbAUC
            // 
            this.tbAUC.Location = new System.Drawing.Point(176, 12);
            this.tbAUC.Name = "tbAUC";
            this.tbAUC.Size = new System.Drawing.Size(100, 20);
            this.tbAUC.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "eGFR [ml/min]";
            this.label9.Click += new System.EventHandler(this.TabSwitcher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Target AUC";
            // 
            // Calculators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 228);
            this.Controls.Add(this.tabCalculators);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.Name = "Calculators";
            this.Text = "Calculators";
            this.tabCalculators.ResumeLayout(false);
            this.tBSA.ResumeLayout(false);
            this.tBSA.PerformLayout();
            this.tCG.ResumeLayout(false);
            this.tCG.PerformLayout();
            this.tCalvert.ResumeLayout(false);
            this.tCalvert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCalculators;
        private System.Windows.Forms.TabPage tBSA;
        private System.Windows.Forms.TabPage tCG;
        private System.Windows.Forms.TabPage tCalvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBSA;
        private System.Windows.Forms.TextBox tbBSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.TextBox tbSC;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCCr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnteCCR;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.TextBox tbDose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGFR;
        private System.Windows.Forms.TextBox tbAUC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUse4Calvert;
        private System.Windows.Forms.Button btnGetEccr;
    }
}