﻿namespace RegimeDatabaseCalculatorSystem
{
    partial class RegimesEditor
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
            if ( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegimesEditor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbExtravasation = new System.Windows.Forms.TextBox();
            this.tabPageDosage = new System.Windows.Forms.TabPage();
            this.tbAdminDays4 = new System.Windows.Forms.TextBox();
            this.tbAdminDays3 = new System.Windows.Forms.TextBox();
            this.tbAdminDays2 = new System.Windows.Forms.TextBox();
            this.tbAdminDays1 = new System.Windows.Forms.TextBox();
            this.cbAdmin4 = new System.Windows.Forms.ComboBox();
            this.cbCalcMethod4 = new System.Windows.Forms.ComboBox();
            this.tbURL4 = new System.Windows.Forms.TextBox();
            this.tbDose4 = new System.Windows.Forms.TextBox();
            this.tbDrugName4 = new System.Windows.Forms.TextBox();
            this.tbURL3 = new System.Windows.Forms.TextBox();
            this.tbURL2 = new System.Windows.Forms.TextBox();
            this.tbURL1 = new System.Windows.Forms.TextBox();
            this.cbCalcMethod3 = new System.Windows.Forms.ComboBox();
            this.cbCalcMethod2 = new System.Windows.Forms.ComboBox();
            this.cbCalcMethod1 = new System.Windows.Forms.ComboBox();
            this.cbAdmin3 = new System.Windows.Forms.ComboBox();
            this.cbAdmin2 = new System.Windows.Forms.ComboBox();
            this.cbAdmin1 = new System.Windows.Forms.ComboBox();
            this.tbDose3 = new System.Windows.Forms.TextBox();
            this.tbDrugName3 = new System.Windows.Forms.TextBox();
            this.tbDose2 = new System.Windows.Forms.TextBox();
            this.tbDrugName2 = new System.Windows.Forms.TextBox();
            this.tbDose1 = new System.Windows.Forms.TextBox();
            this.tbDrugName1 = new System.Windows.Forms.TextBox();
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.numNoCycles = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDaysCycle = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageDosage.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.numNoCycles ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.numDaysCycle ) ).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOverview);
            this.tabControl1.Controls.Add(this.tabPageDosage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 302);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.tbComment);
            this.tabPageOverview.Controls.Add(this.tbDesc);
            this.tabPageOverview.Controls.Add(this.tbExtravasation);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(332, 276);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbComment.Location = new System.Drawing.Point(1, 154);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComment.Size = new System.Drawing.Size(328, 119);
            this.tbComment.TabIndex = 6;
            this.tbComment.Text = "Comment";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(1, 3);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(328, 119);
            this.tbDesc.TabIndex = 4;
            this.tbDesc.Text = "Regime Overview";
            // 
            // tbExtravasation
            // 
            this.tbExtravasation.Location = new System.Drawing.Point(0, 128);
            this.tbExtravasation.Name = "tbExtravasation";
            this.tbExtravasation.Size = new System.Drawing.Size(329, 20);
            this.tbExtravasation.TabIndex = 5;
            this.tbExtravasation.Text = "Extravasation";
            // 
            // tabPageDosage
            // 
            this.tabPageDosage.Controls.Add(this.tbAdminDays4);
            this.tabPageDosage.Controls.Add(this.tbAdminDays3);
            this.tabPageDosage.Controls.Add(this.tbAdminDays2);
            this.tabPageDosage.Controls.Add(this.tbAdminDays1);
            this.tabPageDosage.Controls.Add(this.cbAdmin4);
            this.tabPageDosage.Controls.Add(this.cbCalcMethod4);
            this.tabPageDosage.Controls.Add(this.tbURL4);
            this.tabPageDosage.Controls.Add(this.tbDose4);
            this.tabPageDosage.Controls.Add(this.tbDrugName4);
            this.tabPageDosage.Controls.Add(this.tbURL3);
            this.tabPageDosage.Controls.Add(this.tbURL2);
            this.tabPageDosage.Controls.Add(this.tbURL1);
            this.tabPageDosage.Controls.Add(this.cbCalcMethod3);
            this.tabPageDosage.Controls.Add(this.cbCalcMethod2);
            this.tabPageDosage.Controls.Add(this.cbCalcMethod1);
            this.tabPageDosage.Controls.Add(this.cbAdmin3);
            this.tabPageDosage.Controls.Add(this.cbAdmin2);
            this.tabPageDosage.Controls.Add(this.cbAdmin1);
            this.tabPageDosage.Controls.Add(this.tbDose3);
            this.tabPageDosage.Controls.Add(this.tbDrugName3);
            this.tabPageDosage.Controls.Add(this.tbDose2);
            this.tabPageDosage.Controls.Add(this.tbDrugName2);
            this.tabPageDosage.Controls.Add(this.tbDose1);
            this.tabPageDosage.Controls.Add(this.tbDrugName1);
            this.tabPageDosage.Location = new System.Drawing.Point(4, 22);
            this.tabPageDosage.Name = "tabPageDosage";
            this.tabPageDosage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDosage.Size = new System.Drawing.Size(332, 276);
            this.tabPageDosage.TabIndex = 1;
            this.tabPageDosage.Text = "Dosage";
            this.tabPageDosage.UseVisualStyleBackColor = true;
            // 
            // tbAdminDays4
            // 
            this.tbAdminDays4.Location = new System.Drawing.Point(109, 211);
            this.tbAdminDays4.Name = "tbAdminDays4";
            this.tbAdminDays4.Size = new System.Drawing.Size(100, 20);
            this.tbAdminDays4.TabIndex = 27;
            this.tbAdminDays4.Text = "AdminDays";
            this.tbAdminDays4.Click += new System.EventHandler(this.tbAdminDays4_Click);
            // 
            // tbAdminDays3
            // 
            this.tbAdminDays3.Location = new System.Drawing.Point(109, 146);
            this.tbAdminDays3.Name = "tbAdminDays3";
            this.tbAdminDays3.Size = new System.Drawing.Size(100, 20);
            this.tbAdminDays3.TabIndex = 21;
            this.tbAdminDays3.Text = "AdminDays";
            this.tbAdminDays3.Click += new System.EventHandler(this.tbAdminDays3_Click);
            // 
            // tbAdminDays2
            // 
            this.tbAdminDays2.Location = new System.Drawing.Point(109, 87);
            this.tbAdminDays2.Name = "tbAdminDays2";
            this.tbAdminDays2.Size = new System.Drawing.Size(100, 20);
            this.tbAdminDays2.TabIndex = 15;
            this.tbAdminDays2.Text = "AdminDays";
            this.tbAdminDays2.Click += new System.EventHandler(this.tbAdminDays2_Click);
            // 
            // tbAdminDays1
            // 
            this.tbAdminDays1.Location = new System.Drawing.Point(109, 35);
            this.tbAdminDays1.Name = "tbAdminDays1";
            this.tbAdminDays1.Size = new System.Drawing.Size(100, 20);
            this.tbAdminDays1.TabIndex = 9;
            this.tbAdminDays1.Text = "AdminDays";
            this.tbAdminDays1.Click += new System.EventHandler(this.tbAdminDays1_Click);
            // 
            // cbAdmin4
            // 
            this.cbAdmin4.FormattingEnabled = true;
            this.cbAdmin4.Location = new System.Drawing.Point(283, 190);
            this.cbAdmin4.Name = "cbAdmin4";
            this.cbAdmin4.Size = new System.Drawing.Size(45, 21);
            this.cbAdmin4.TabIndex = 25;
            // 
            // cbCalcMethod4
            // 
            this.cbCalcMethod4.FormattingEnabled = true;
            this.cbCalcMethod4.Items.AddRange(new object[] {
            "mg/m²",
            "AUC"});
            this.cbCalcMethod4.Location = new System.Drawing.Point(215, 190);
            this.cbCalcMethod4.Name = "cbCalcMethod4";
            this.cbCalcMethod4.Size = new System.Drawing.Size(62, 21);
            this.cbCalcMethod4.TabIndex = 24;
            // 
            // tbURL4
            // 
            this.tbURL4.Location = new System.Drawing.Point(3, 211);
            this.tbURL4.Name = "tbURL4";
            this.tbURL4.Size = new System.Drawing.Size(100, 20);
            this.tbURL4.TabIndex = 26;
            this.tbURL4.Text = "URL";
            // 
            // tbDose4
            // 
            this.tbDose4.Location = new System.Drawing.Point(109, 190);
            this.tbDose4.Name = "tbDose4";
            this.tbDose4.Size = new System.Drawing.Size(100, 20);
            this.tbDose4.TabIndex = 23;
            this.tbDose4.Text = "Dose";
            // 
            // tbDrugName4
            // 
            this.tbDrugName4.Location = new System.Drawing.Point(3, 190);
            this.tbDrugName4.Name = "tbDrugName4";
            this.tbDrugName4.Size = new System.Drawing.Size(100, 20);
            this.tbDrugName4.TabIndex = 22;
            this.tbDrugName4.Text = "Name";
            // 
            // tbURL3
            // 
            this.tbURL3.Location = new System.Drawing.Point(3, 146);
            this.tbURL3.Name = "tbURL3";
            this.tbURL3.Size = new System.Drawing.Size(100, 20);
            this.tbURL3.TabIndex = 20;
            this.tbURL3.Text = "URL";
            // 
            // tbURL2
            // 
            this.tbURL2.Location = new System.Drawing.Point(3, 88);
            this.tbURL2.Name = "tbURL2";
            this.tbURL2.Size = new System.Drawing.Size(100, 20);
            this.tbURL2.TabIndex = 14;
            this.tbURL2.Text = "URL";
            // 
            // tbURL1
            // 
            this.tbURL1.Location = new System.Drawing.Point(3, 35);
            this.tbURL1.Name = "tbURL1";
            this.tbURL1.Size = new System.Drawing.Size(100, 20);
            this.tbURL1.TabIndex = 8;
            this.tbURL1.Text = "URL";
            // 
            // cbCalcMethod3
            // 
            this.cbCalcMethod3.FormattingEnabled = true;
            this.cbCalcMethod3.Items.AddRange(new object[] {
            "mg/m²",
            "AUC"});
            this.cbCalcMethod3.Location = new System.Drawing.Point(215, 120);
            this.cbCalcMethod3.Name = "cbCalcMethod3";
            this.cbCalcMethod3.Size = new System.Drawing.Size(62, 21);
            this.cbCalcMethod3.TabIndex = 18;
            // 
            // cbCalcMethod2
            // 
            this.cbCalcMethod2.FormattingEnabled = true;
            this.cbCalcMethod2.Items.AddRange(new object[] {
            "mg/m²",
            "AUC"});
            this.cbCalcMethod2.Location = new System.Drawing.Point(215, 61);
            this.cbCalcMethod2.Name = "cbCalcMethod2";
            this.cbCalcMethod2.Size = new System.Drawing.Size(62, 21);
            this.cbCalcMethod2.TabIndex = 12;
            // 
            // cbCalcMethod1
            // 
            this.cbCalcMethod1.FormattingEnabled = true;
            this.cbCalcMethod1.Items.AddRange(new object[] {
            "mg /m²",
            "AUC"});
            this.cbCalcMethod1.Location = new System.Drawing.Point(215, 9);
            this.cbCalcMethod1.Name = "cbCalcMethod1";
            this.cbCalcMethod1.Size = new System.Drawing.Size(62, 21);
            this.cbCalcMethod1.TabIndex = 6;
            // 
            // cbAdmin3
            // 
            this.cbAdmin3.FormattingEnabled = true;
            this.cbAdmin3.Location = new System.Drawing.Point(283, 120);
            this.cbAdmin3.Name = "cbAdmin3";
            this.cbAdmin3.Size = new System.Drawing.Size(45, 21);
            this.cbAdmin3.TabIndex = 19;
            // 
            // cbAdmin2
            // 
            this.cbAdmin2.FormattingEnabled = true;
            this.cbAdmin2.Location = new System.Drawing.Point(283, 61);
            this.cbAdmin2.Name = "cbAdmin2";
            this.cbAdmin2.Size = new System.Drawing.Size(45, 21);
            this.cbAdmin2.TabIndex = 13;
            // 
            // cbAdmin1
            // 
            this.cbAdmin1.FormattingEnabled = true;
            this.cbAdmin1.Location = new System.Drawing.Point(283, 9);
            this.cbAdmin1.Name = "cbAdmin1";
            this.cbAdmin1.Size = new System.Drawing.Size(45, 21);
            this.cbAdmin1.TabIndex = 7;
            // 
            // tbDose3
            // 
            this.tbDose3.Location = new System.Drawing.Point(109, 120);
            this.tbDose3.Name = "tbDose3";
            this.tbDose3.Size = new System.Drawing.Size(100, 20);
            this.tbDose3.TabIndex = 17;
            this.tbDose3.Text = "Dose";
            // 
            // tbDrugName3
            // 
            this.tbDrugName3.Location = new System.Drawing.Point(3, 120);
            this.tbDrugName3.Name = "tbDrugName3";
            this.tbDrugName3.Size = new System.Drawing.Size(100, 20);
            this.tbDrugName3.TabIndex = 16;
            this.tbDrugName3.Text = "Name";
            // 
            // tbDose2
            // 
            this.tbDose2.Location = new System.Drawing.Point(109, 61);
            this.tbDose2.Name = "tbDose2";
            this.tbDose2.Size = new System.Drawing.Size(100, 20);
            this.tbDose2.TabIndex = 11;
            this.tbDose2.Text = "Dose";
            // 
            // tbDrugName2
            // 
            this.tbDrugName2.Location = new System.Drawing.Point(3, 61);
            this.tbDrugName2.Name = "tbDrugName2";
            this.tbDrugName2.Size = new System.Drawing.Size(100, 20);
            this.tbDrugName2.TabIndex = 10;
            this.tbDrugName2.Text = "Name";
            // 
            // tbDose1
            // 
            this.tbDose1.Location = new System.Drawing.Point(109, 9);
            this.tbDose1.Name = "tbDose1";
            this.tbDose1.Size = new System.Drawing.Size(100, 20);
            this.tbDose1.TabIndex = 5;
            this.tbDose1.Text = "Dose";
            // 
            // tbDrugName1
            // 
            this.tbDrugName1.Location = new System.Drawing.Point(3, 9);
            this.tbDrugName1.Name = "tbDrugName1";
            this.tbDrugName1.Size = new System.Drawing.Size(100, 20);
            this.tbDrugName1.TabIndex = 4;
            this.tbDrugName1.Text = "Name";
            // 
            // tbRegName
            // 
            this.tbRegName.Location = new System.Drawing.Point(4, 3);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(125, 20);
            this.tbRegName.TabIndex = 0;
            this.tbRegName.Text = "RegimeName";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSave.Location = new System.Drawing.Point(260, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numNoCycles
            // 
            this.numNoCycles.Location = new System.Drawing.Point(186, 3);
            this.numNoCycles.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numNoCycles.Name = "numNoCycles";
            this.numNoCycles.Size = new System.Drawing.Size(36, 20);
            this.numNoCycles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "#Cycles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Days/Cycle";
            // 
            // numDaysCycle
            // 
            this.numDaysCycle.Location = new System.Drawing.Point(296, 3);
            this.numDaysCycle.Name = "numDaysCycle";
            this.numDaysCycle.Size = new System.Drawing.Size(39, 20);
            this.numDaysCycle.TabIndex = 2;
            // 
            // RegimesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 356);
            this.Controls.Add(this.numDaysCycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNoCycles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbRegName);
            this.HelpButton = true;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.MinimumSize = new System.Drawing.Size(350, 394);
            this.Name = "RegimesEditor";
            this.Text = "RegimeEditor";
            this.SizeChanged += new System.EventHandler(this.RegimesEditor_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            this.tabPageDosage.ResumeLayout(false);
            this.tabPageDosage.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.numNoCycles ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.numDaysCycle ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.TabPage tabPageDosage;
        private System.Windows.Forms.TextBox tbExtravasation;
        private System.Windows.Forms.TextBox tbDose2;
        private System.Windows.Forms.TextBox tbDrugName2;
        private System.Windows.Forms.TextBox tbDose1;
        private System.Windows.Forms.TextBox tbDrugName1;
        private System.Windows.Forms.TextBox tbDose3;
        private System.Windows.Forms.TextBox tbDrugName3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbAdmin3;
        private System.Windows.Forms.ComboBox cbAdmin2;
        private System.Windows.Forms.ComboBox cbAdmin1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.ComboBox cbCalcMethod1;
        private System.Windows.Forms.ComboBox cbCalcMethod3;
        private System.Windows.Forms.ComboBox cbCalcMethod2;
        private System.Windows.Forms.TextBox tbURL3;
        private System.Windows.Forms.TextBox tbURL2;
        private System.Windows.Forms.TextBox tbURL1;
        private System.Windows.Forms.ComboBox cbAdmin4;
        private System.Windows.Forms.ComboBox cbCalcMethod4;
        private System.Windows.Forms.TextBox tbURL4;
        private System.Windows.Forms.TextBox tbDose4;
        private System.Windows.Forms.TextBox tbDrugName4;
        private System.Windows.Forms.NumericUpDown numNoCycles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDaysCycle;
        private System.Windows.Forms.TextBox tbAdminDays1;
        private System.Windows.Forms.TextBox tbAdminDays4;
        private System.Windows.Forms.TextBox tbAdminDays3;
        private System.Windows.Forms.TextBox tbAdminDays2;
    }
}