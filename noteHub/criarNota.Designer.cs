namespace noteHub
{
    partial class criarNota
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
            this.txtbNota = new System.Windows.Forms.RichTextBox();
            this.cbTopicos = new System.Windows.Forms.ComboBox();
            this.statusStripCriarNota = new System.Windows.Forms.StatusStrip();
            this.Caracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.statusStripCriarNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbNota
            // 
            this.txtbNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbNota.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtbNota.Location = new System.Drawing.Point(12, 71);
            this.txtbNota.Name = "txtbNota";
            this.txtbNota.Size = new System.Drawing.Size(292, 265);
            this.txtbNota.TabIndex = 0;
            this.txtbNota.Text = "Comece uma nova nota...";
            this.txtbNota.Click += new System.EventHandler(this.txtbNota_Click);
            this.txtbNota.TextChanged += new System.EventHandler(this.txtbNota_TextChanged);
            this.txtbNota.Leave += new System.EventHandler(this.txtbNota_Leave);
            // 
            // cbTopicos
            // 
            this.cbTopicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTopicos.FormattingEnabled = true;
            this.cbTopicos.Location = new System.Drawing.Point(172, 26);
            this.cbTopicos.Name = "cbTopicos";
            this.cbTopicos.Size = new System.Drawing.Size(132, 21);
            this.cbTopicos.TabIndex = 1;
            this.cbTopicos.SelectedIndexChanged += new System.EventHandler(this.cbTopicos_SelectedIndexChanged);
            // 
            // statusStripCriarNota
            // 
            this.statusStripCriarNota.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripCriarNota.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Caracteres});
            this.statusStripCriarNota.Location = new System.Drawing.Point(0, 386);
            this.statusStripCriarNota.Name = "statusStripCriarNota";
            this.statusStripCriarNota.Size = new System.Drawing.Size(316, 22);
            this.statusStripCriarNota.TabIndex = 2;
            this.statusStripCriarNota.Text = "Caracteres";
            // 
            // Caracteres
            // 
            this.Caracteres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Caracteres.Name = "Caracteres";
            this.Caracteres.Size = new System.Drawing.Size(74, 17);
            this.Caracteres.Text = "Caracteres: 0";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(12, 26);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(142, 20);
            this.txtbTitulo.TabIndex = 3;
            this.txtbTitulo.TextChanged += new System.EventHandler(this.txtbTitulo_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 11);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(33, 12);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Título";
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.saveNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveNoteBtn.Location = new System.Drawing.Point(229, 351);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.saveNoteBtn.TabIndex = 5;
            this.saveNoteBtn.Text = "Salvar";
            this.saveNoteBtn.UseVisualStyleBackColor = false;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // criarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(316, 408);
            this.Controls.Add(this.saveNoteBtn);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.statusStripCriarNota);
            this.Controls.Add(this.cbTopicos);
            this.Controls.Add(this.txtbNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "criarNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "criarNota";
            this.Load += new System.EventHandler(this.criarNota_Load);
            this.statusStripCriarNota.ResumeLayout(false);
            this.statusStripCriarNota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtbNota;
        private System.Windows.Forms.ComboBox cbTopicos;
        private System.Windows.Forms.StatusStrip statusStripCriarNota;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.ToolStripStatusLabel Caracteres;
    }
}