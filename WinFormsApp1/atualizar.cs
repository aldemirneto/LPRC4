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
    public partial class atualizar : Form
    {
        public atualizar()
        {
            InitializeComponent();
        }

        private void UpdateUSer(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário Alterado.");
            this.Hide();
            home home = new home();
            home.Show();
            this.Close();
        }

        private void DropUSer(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário Deletado.");
            this.Hide();
            home home = new home();
            home.Show();
            this.Close();

        }
    }
}
