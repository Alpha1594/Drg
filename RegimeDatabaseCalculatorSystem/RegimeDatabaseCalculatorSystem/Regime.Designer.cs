namespace RegimeDatabaseCalculatorSystem
{
    partial class Regime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regime));
            this.btnNP = new System.Windows.Forms.Button();
            this.listPatients = new System.Windows.Forms.ListBox();
            this.listRegimes = new System.Windows.Forms.ListBox();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regimeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNP
            // 
            this.btnNP.Location = new System.Drawing.Point(194, 255);
            this.btnNP.Name = "btnNP";
            this.btnNP.Size = new System.Drawing.Size(98, 23);
            this.btnNP.TabIndex = 2;
            this.btnNP.Text = "&Add New Patient";
            this.btnNP.UseVisualStyleBackColor = true;
            this.btnNP.Click += new System.EventHandler(this.btnNP_Click);
            // 
            // listPatients
            // 
            this.listPatients.FormattingEnabled = true;
            this.listPatients.Location = new System.Drawing.Point(122, 27);
            this.listPatients.Name = "listPatients";
            this.listPatients.Size = new System.Drawing.Size(170, 199);
            this.listPatients.TabIndex = 16;
            this.listPatients.DoubleClick += new System.EventHandler(this.listPatients_DoubleClick);
            this.listPatients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listPatients_KeyPress);
            // 
            // listRegimes
            // 
            this.listRegimes.FormattingEnabled = true;
            this.listRegimes.Location = new System.Drawing.Point(0, 27);
            this.listRegimes.Name = "listRegimes";
            this.listRegimes.Size = new System.Drawing.Size(120, 225);
            this.listRegimes.TabIndex = 17;
            this.listRegimes.SelectedIndexChanged += new System.EventHandler(this.listRegimes_SelectedIndexChanged);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(122, 229);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(100, 20);
            this.tbSearchName.TabIndex = 0;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(228, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(122, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(0, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "&Reset Filter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regimeEditorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // regimeEditorToolStripMenuItem
            // 
            this.regimeEditorToolStripMenuItem.Name = "regimeEditorToolStripMenuItem";
            this.regimeEditorToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R ) ) );
            this.regimeEditorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.regimeEditorToolStripMenuItem.Text = "&Regime Editor";
            // 
            // convertersToolStripMenuItem
            // 
            this.convertersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSAToolStripMenuItem,
            this.renalToolStripMenuItem,
            this.calvertToolStripMenuItem});
            this.convertersToolStripMenuItem.Name = "convertersToolStripMenuItem";
            this.convertersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.convertersToolStripMenuItem.Text = "Calculators";
            // 
            // bSAToolStripMenuItem
            // 
            this.bSAToolStripMenuItem.AutoToolTip = true;
            this.bSAToolStripMenuItem.Name = "bSAToolStripMenuItem";
            this.bSAToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B ) ) );
            this.bSAToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bSAToolStripMenuItem.Text = "&BSA";
            this.bSAToolStripMenuItem.ToolTipText = "BSA using Dubois and Dubois Method";
            // 
            // renalToolStripMenuItem
            // 
            this.renalToolStripMenuItem.AutoToolTip = true;
            this.renalToolStripMenuItem.Name = "renalToolStripMenuItem";
            this.renalToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C ) ) );
            this.renalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renalToolStripMenuItem.Text = "&Cockcroft-Gault";
            this.renalToolStripMenuItem.ToolTipText = "Cockcroft-Gault Formula for Creatinine Clearance Rate";
            // 
            // calvertToolStripMenuItem
            // 
            this.calvertToolStripMenuItem.Name = "calvertToolStripMenuItem";
            this.calvertToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A ) ) );
            this.calvertToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calvertToolStripMenuItem.Text = "C&alvert";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Regime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 277);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.listRegimes);
            this.Controls.Add(this.listPatients);
            this.Controls.Add(this.btnNP);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.Name = "Regime";
            this.Text = "Regime";
            this.Activated += new System.EventHandler(this.Regime_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNP;
        private System.Windows.Forms.ListBox listPatients;
        private System.Windows.Forms.ListBox listRegimes;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regimeEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}