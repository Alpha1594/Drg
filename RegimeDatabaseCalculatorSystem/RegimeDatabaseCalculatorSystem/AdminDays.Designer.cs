namespace RegimeDatabaseCalculatorSystem
{
    partial class AdminDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDays));
            this.lbDayCycle = new System.Windows.Forms.CheckedListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDayCycle
            // 
            this.lbDayCycle.CheckOnClick = true;
            this.lbDayCycle.FormattingEnabled = true;
            this.lbDayCycle.Location = new System.Drawing.Point(0, 0);
            this.lbDayCycle.MultiColumn = true;
            this.lbDayCycle.Name = "lbDayCycle";
            this.lbDayCycle.Size = new System.Drawing.Size(290, 244);
            this.lbDayCycle.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSubmit.Location = new System.Drawing.Point(215, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // AdminDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbDayCycle);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.Name = "AdminDays";
            this.Text = "AdminDays";
            this.SizeChanged += new System.EventHandler(this.FrmDayCycle_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbDayCycle;
        private System.Windows.Forms.Button btnSubmit;
    }
}