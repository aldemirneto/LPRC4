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
            this.btnSalvar.Location = new System.Drawing.Point(120, 357);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 31);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.UpdateUSer);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(120, 437);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 31);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir Usuario";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.DropUSer);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 96);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 27);
            this.textBox3.TabIndex = 12;
            // 
            // lblSenhaAtualizar
            // 
            this.lblSenhaAtualizar.AutoSize = true;
            this.lblSenhaAtualizar.Location = new System.Drawing.Point(120, 271);
            this.lblSenhaAtualizar.Name = "lblSenhaAtualizar";
            this.lblSenhaAtualizar.Size = new System.Drawing.Size(49, 20);
            this.lblSenhaAtualizar.TabIndex = 11;
            this.lblSenhaAtualizar.Text = "Senha";
            // 
            // lblUsuarioAtualizar
            // 
            this.lblUsuarioAtualizar.AutoSize = true;
            this.lblUsuarioAtualizar.Location = new System.Drawing.Point(120, 169);
            this.lblUsuarioAtualizar.Name = "lblUsuarioAtualizar";
            this.lblUsuarioAtualizar.Size = new System.Drawing.Size(59, 20);
            this.lblUsuarioAtualizar.TabIndex = 10;
            this.lblUsuarioAtualizar.Text = "Usuario";
            // 
            // lblNomeAtualizar
            // 
            this.lblNomeAtualizar.AutoSize = true;
            this.lblNomeAtualizar.Location = new System.Drawing.Point(120, 72);
            this.lblNomeAtualizar.Name = "lblNomeAtualizar";
            this.lblNomeAtualizar.Size = new System.Drawing.Size(50, 20);
            this.lblNomeAtualizar.TabIndex = 9;
            this.lblNomeAtualizar.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 295);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 7;
            // 
            // atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 484);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblSenhaAtualizar);
            this.Controls.Add(this.lblUsuarioAtualizar);
            this.Controls.Add(this.lblNomeAtualizar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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