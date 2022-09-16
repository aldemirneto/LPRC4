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
    public partial class main : Form
    {
        User user { get; set; }
        public main()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            listaNotas myNewListaNotas = new listaNotas();
            myNewListaNotas.MdiParent = this;
            myNewListaNotas.Show();
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null) ActiveMdiChild.Close();
            criarNota myNewNote = new criarNota();
            myNewNote.MdiParent = this;
            myNewNote.Show();
        }

        private void tópicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            criarTopico myNewTopic = new criarTopico();
            myNewTopic.MdiParent = this;
            myNewTopic.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            telaSobre myNewTelaSobre = new telaSobre();
            myNewTelaSobre.MdiParent = this;
            myNewTelaSobre.Show();
            // MessageBox.Show(myNewTelaSobre.MdiParent.ToString());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sair mysair = new sair();
            mysair.name = user.Name;
            DialogResult res = mysair.ShowDialog();
            if(res == DialogResult.OK)
            {
                MessageBox.Show("Você será desconectado!");
            }
            else if(res == DialogResult.Cancel)
            {
                MessageBox.Show("Sessão mantida!");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            user = new User();
            user.Name = "Gabryel";
            user.Username = "byelbueno";
            user.Password = "1234";
        }
    }
}
