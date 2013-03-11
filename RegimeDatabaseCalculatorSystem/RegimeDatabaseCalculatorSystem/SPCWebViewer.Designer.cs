namespace RegimeDatabaseCalculatorSystem
{
    partial class SPCviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPCviewer));
            this.SPCbrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // SPCbrowser
            // 
            this.SPCbrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPCbrowser.Location = new System.Drawing.Point(0, 0);
            this.SPCbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.SPCbrowser.Name = "SPCbrowser";
            this.SPCbrowser.Size = new System.Drawing.Size(600, 453);
            this.SPCbrowser.TabIndex = 0;
            // 
            // SPCviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 453);
            this.Controls.Add(this.SPCbrowser);
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject("$this.Icon") ) );
            this.Name = "SPCviewer";
            this.Text = "SPC viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser SPCbrowser;
    }
}