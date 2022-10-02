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
        List<Note> notes = new List<Note>();
        List<Topic> topics = new List<Topic>();

        public main()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() != typeof(listaNotas))
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                listaNotas myNewListaNotas = new listaNotas();
                myNewListaNotas.MdiParent = this;
                myNewListaNotas.minhasNotas = this.notes;
                myNewListaNotas.topics = this.topics;
                myNewListaNotas.Show();
            }
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() != typeof(criarNota))
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                criarNota myNewNote = new criarNota();
                myNewNote.MdiParent = this;
                myNewNote.notes = this.notes;
                myNewNote.topics = this.topics;
                myNewNote.Show();
            }else
            {
                MessageBox.Show("Salve sua nota primeiro");
            }
        }

        private void tópicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() != typeof(criarTopico))
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                criarTopico myNewTopic = new criarTopico();
                myNewTopic.topics = this.topics;
                myNewTopic.MdiParent = this;
                myNewTopic.Show();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() != typeof(telaSobre))
            {
                if (ActiveMdiChild != null) ActiveMdiChild.Close();
                telaSobre myNewTelaSobre = new telaSobre();
                myNewTelaSobre.MdiParent = this;
                myNewTelaSobre.Show();
            }
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
           user = new User("Gabryel", "byelbueno", "1234");
            listaNotas listaNotaDefault = new listaNotas();
            listaNotaDefault.MdiParent = this;
            listaNotaDefault.minhasNotas = this.notes;
            listaNotaDefault.topics = this.topics;
            listaNotaDefault.Show();

        }

        private void tópicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*foreach (Topic t in topics)
            {
                this.tópicosToolStripMenuItem.DropDownItems.Add(t.DescTopic);
            }*/
        }
    }
}
