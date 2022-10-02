namespace noteHub
{
    partial class listaNotas
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
            this.DGV_Lista_de_Notas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lista_de_Notas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Lista_de_Notas
            // 
            this.DGV_Lista_de_Notas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Lista_de_Notas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Lista_de_Notas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Lista_de_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Lista_de_Notas.ColumnHeadersVisible = false;
            this.DGV_Lista_de_Notas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Data,
            this.Topico,
            this.Descricao});
            this.DGV_Lista_de_Notas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Lista_de_Notas.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Lista_de_Notas.Location = new System.Drawing.Point(0, 0);
            this.DGV_Lista_de_Notas.Name = "DGV_Lista_de_Notas";
            this.DGV_Lista_de_Notas.Size = new System.Drawing.Size(316, 408);
            this.DGV_Lista_de_Notas.TabIndex = 0;
            this.DGV_Lista_de_Notas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Lista_de_Notas_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Date";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Visible = false;
            // 
            // Topico
            // 
            this.Topico.DataPropertyName = "Topic";
            this.Topico.HeaderText = "Tópico";
            this.Topico.Name = "Topico";
            this.Topico.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Description";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // listaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 408);
            this.Controls.Add(this.DGV_Lista_de_Notas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaNotas";
            this.Load += new System.EventHandler(this.listaNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lista_de_Notas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Lista_de_Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}