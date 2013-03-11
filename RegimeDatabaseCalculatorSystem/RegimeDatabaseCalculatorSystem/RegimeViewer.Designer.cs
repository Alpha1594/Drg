namespace RegimeDatabaseCalculatorSystem
{
    partial class RegimeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegimeViewer));
            this.listRegimes = new System.Windows.Forms.ListBox();
            this.btnNewReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRegimes
            // 
            this.listRegimes.FormattingEnabled = true;
            this.listRegimes.Location = new System.Drawing.Point(0, -3);
            this.listRegimes.Name = "listRegimes";
            this.listRegimes.Size = new System.Drawing.Size(284, 238);
            this.listRegimes.TabIndex = 0;
            this.listRegimes.SelectedIndexChanged += new System.EventHandler(this.listRegimes_SelectedIndexChanged);
            // 
            // btnNewReg
            // 
            this.btnNewReg.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnNewReg.Location = new System.Drawing.Point(202, 239);
            this.btnNewReg.Name = "btnNewReg";
            this.btnNewReg.Size = new System.Drawing.Size(82, 23);
            this.btnNewReg.TabIndex = 1;
            this.btnNewReg.Text = "New Regime";
            this.btnNewReg.UseVisualStyleBackColor = true;
            this.btnNewReg.Click += new System.EventHandler(this.btnNewReg_Click);
            // 
            // RegimeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnNewReg);
            this.Controls.Add(this.listRegimes);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.Name = "RegimeViewer";
            this.Text = "RegimeViewer";
            this.Activated += new System.EventHandler(this.RegimeViewer_Activated);
            this.SizeChanged += new System.EventHandler(this.RegimeViewer_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRegimes;
        private System.Windows.Forms.Button btnNewReg;
    }
}