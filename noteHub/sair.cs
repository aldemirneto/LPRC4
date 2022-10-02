using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteHub
{
    public partial class sair : Form
    {
        public String name = "";
  
        public sair()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Application.Exit();
        }

        private void sair_Load(object sender, EventArgs e)
        {
            this.lbl_sair.Text = "Deseja mesmo sair, "+name+"?";
        }
    }
}
