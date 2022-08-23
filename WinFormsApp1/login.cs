using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void Entrar(object sender, EventArgs e)
        {
            
            this.Hide();
            home h1 = new home();
            h1.Show();
            
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrar a1 = new cadastrar();
            a1.Show();
        }
    }
}
