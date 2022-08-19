namespace WinFormsApp1
{
    partial class atualizar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSenhaAtualizar = new System.Windows.Forms.Label();
            this.lblUsuarioAtualizar = new System.Windows.Forms.Label();
            this.lblNomeAtualizar = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(105, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(105, 328);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir Usuario";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 23);
            this.textBox3.TabIndex = 12;
            // 
            // lblSenhaAtualizar
            // 
            this.lblSenhaAtualizar.AutoSize = true;
            this.lblSenhaAtualizar.Location = new System.Drawing.Point(105, 203);
            this.lblSenhaAtualizar.Name = "lblSenhaAtualizar";
            this.lblSenhaAtualizar.Size = new System.Drawing.Size(39, 15);
            this.lblSenhaAtualizar.TabIndex = 11;
            this.lblSenhaAtualizar.Text = "Senha";
            // 
            // lblUsuarioAtualizar
            // 
            this.lblUsuarioAtualizar.AutoSize = true;
            this.lblUsuarioAtualizar.Location = new System.Drawing.Point(105, 127);
            this.lblUsuarioAtualizar.Name = "lblUsuarioAtualizar";
            this.lblUsuarioAtualizar.Size = new System.Drawing.Size(47, 15);
            this.lblUsuarioAtualizar.TabIndex = 10;
            this.lblUsuarioAtualizar.Text = "Usuario";
            // 
            // lblNomeAtualizar
            // 
            this.lblNomeAtualizar.AutoSize = true;
            this.lblNomeAtualizar.Location = new System.Drawing.Point(105, 54);
            this.lblNomeAtualizar.Name = "lblNomeAtualizar";
            this.lblNomeAtualizar.Size = new System.Drawing.Size(40, 15);
            this.lblNomeAtualizar.TabIndex = 9;
            this.lblNomeAtualizar.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 7;
            // 
            // atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblSenhaAtualizar);
            this.Controls.Add(this.lblUsuarioAtualizar);
            this.Controls.Add(this.lblNomeAtualizar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Name = "atualizar";
            this.Text = "atualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Button btnExcluir;
        private TextBox textBox3;
        private Label lblSenhaAtualizar;
        private Label lblUsuarioAtualizar;
        private Label lblNomeAtualizar;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}