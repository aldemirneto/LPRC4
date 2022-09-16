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
    public partial class mainPrincipal : Form
    {
        public mainPrincipal()
        {
            InitializeComponent();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home myHome = new home();
            myHome.MdiParent = this;
            myHome.Show();
        }

        private void mainPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrar mycadastrar = new cadastrar();
            mycadastrar.MdiParent = this;
            mycadastrar.Show();
        }
    }
}
