namespace RegimeDatabaseCalculatorSystem
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regimeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegCall = new System.Windows.Forms.Button();
            this.btnCalcCall = new System.Windows.Forms.Button();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(198, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.regimeEditorToolStripMenuItem.Click += new System.EventHandler(this.regimeEditorToolStripMenuItem_Click);
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
            this.bSAToolStripMenuItem.Click += new System.EventHandler(this.bSAToolStripMenuItem_Click);
            // 
            // renalToolStripMenuItem
            // 
            this.renalToolStripMenuItem.AutoToolTip = true;
            this.renalToolStripMenuItem.Name = "renalToolStripMenuItem";
            this.renalToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C ) ) );
            this.renalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renalToolStripMenuItem.Text = "&Cockcroft-Gault";
            this.renalToolStripMenuItem.ToolTipText = "Cockcroft-Gault Formula for Creatinine Clearance Rate";
            this.renalToolStripMenuItem.Click += new System.EventHandler(this.renalToolStripMenuItem_Click);
            // 
            // calvertToolStripMenuItem
            // 
            this.calvertToolStripMenuItem.Name = "calvertToolStripMenuItem";
            this.calvertToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A ) ) );
            this.calvertToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calvertToolStripMenuItem.Text = "C&alvert";
            this.calvertToolStripMenuItem.Click += new System.EventHandler(this.calvertToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnRegCall
            // 
            this.btnRegCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ));
            this.btnRegCall.Location = new System.Drawing.Point(47, 36);
            this.btnRegCall.Name = "btnRegCall";
            this.btnRegCall.Size = new System.Drawing.Size(103, 53);
            this.btnRegCall.TabIndex = 1;
            this.btnRegCall.Text = "&Regime";
            this.btnRegCall.UseVisualStyleBackColor = true;
            this.btnRegCall.Click += new System.EventHandler(this.btnRegCall_Click);
            // 
            // btnCalcCall
            // 
            this.btnCalcCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ));
            this.btnCalcCall.Location = new System.Drawing.Point(47, 110);
            this.btnCalcCall.Name = "btnCalcCall";
            this.btnCalcCall.Size = new System.Drawing.Size(103, 53);
            this.btnCalcCall.TabIndex = 2;
            this.btnCalcCall.Text = "&Calculators";
            this.btnCalcCall.UseVisualStyleBackColor = true;
            this.btnCalcCall.Click += new System.EventHandler(this.btnCalcCall_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U ) ) );
            this.userToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.userToolStripMenuItem.Text = "&User Manual";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 174);
            this.Controls.Add(this.btnCalcCall);
            this.Controls.Add(this.btnRegCall);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartScreen";
            this.Text = "Start";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnRegCall;
        private System.Windows.Forms.Button btnCalcCall;
        private System.Windows.Forms.ToolStripMenuItem bSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regimeEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

