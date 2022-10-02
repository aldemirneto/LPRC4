namespace noteHub
{
    partial class telaSobre
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
            this.lbSobre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSobre
            // 
            this.lbSobre.AutoSize = true;
            this.lbSobre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSobre.Location = new System.Drawing.Point(0, 0);
            this.lbSobre.Name = "lbSobre";
            this.lbSobre.Size = new System.Drawing.Size(35, 13);
            this.lbSobre.TabIndex = 0;
            this.lbSobre.Text = "Sobre";
            // 
            // telaSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 408);
            this.Controls.Add(this.lbSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaSobre";
            this.Load += new System.EventHandler(this.telaSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSobre;
    }
}