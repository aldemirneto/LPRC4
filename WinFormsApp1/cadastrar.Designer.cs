namespace WinFormsApp1
{
    partial class cadastrar
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuarioCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(140, 248);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(120, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsuarioCadastro
            // 
            this.lblUsuarioCadastro.AutoSize = true;
            this.lblUsuarioCadastro.Location = new System.Drawing.Point(120, 103);
            this.lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            this.lblUsuarioCadastro.Size = new System.Drawing.Size(47, 15);
            this.lblUsuarioCadastro.TabIndex = 4;
            this.lblUsuarioCadastro.Text = "Usuario";
            this.lblUsuarioCadastro.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(120, 179);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(39, 15);
            this.lblSenhaCadastro.TabIndex = 5;
            this.lblSenhaCadastro.Text = "Senha";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 23);
            this.textBox3.TabIndex = 6;
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 329);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblSenhaCadastro);
            this.Controls.Add(this.lblUsuarioCadastro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblNome;
        private Label lblUsuarioCadastro;
        private Label lblSenhaCadastro;
        private TextBox textBox3;
    }
}