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
    public partial class criarNota : Form
    {
        public Note localNote = new Note();
        public List<Topic> topics;
        public List<Note> notes;
        public int id;

        public criarNota()
        {
            InitializeComponent();
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {   if (localNote.Name != null && localNote.Description != null)
            {

                if (localNote.Date == null) // significa que e uma nota nova
                {
                    DateTime today = DateTime.Now;
                    localNote.Date = today.Date.ToString("dd/MM/yyyy");
                    notes.Add(localNote);
                }
                else
                {
                    notes[id] = localNote;
                }
                MessageBox.Show("Salvo com sucesso!");

                listaNotas myListaNotas = new listaNotas();
                myListaNotas.minhasNotas = this.notes;
                myListaNotas.topics = this.topics;
                myListaNotas.MdiParent = this.MdiParent;
                myListaNotas.Show();
                // this.Hide();
            }else
            {
                if (string.IsNullOrEmpty(localNote.Name))
                {
                    MessageBox.Show("Por favor, preencha o título da nota.");
                }
                else
                {
                    MessageBox.Show("Por favor, preencha o corpo da nota.");
                }
  
            }
        }

        private void txtbNota_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(localNote.Description) 
                && 
                this.txtbNota.Text == "Comece uma nova nota...")
            {
                this.txtbNota.Text = null;
                this.txtbNota.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtbNota_Leave(object sender, EventArgs e)
        {
            if (this.txtbNota.Text == null || this.txtbNota.Text == "")
            {
                this.txtbNota.Text = "Comece uma nova nota...";
                this.txtbNota.ForeColor = SystemColors.ControlDark;
            }

        }

        private void txtbTitulo_TextChanged(object sender, EventArgs e)
        {
            localNote.Name = txtbTitulo.Text;
        }

        private void txtbNota_TextChanged(object sender, EventArgs e)
        {
            if (this.txtbNota.Text != "Comece uma nova nota...")
            {
                localNote.Description = txtbNota.Text;
                this.statusStripCriarNota.Items[0].Text = "Caracteres: " + (localNote.Description.Replace(" ","").Replace("\n", "")).Length.ToString();
              
            }
        }

        private void criarNota_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbTitulo;
            int auxTopicId = localNote.Topic;

            if(topics.Count > 0)
            {
                List<String> topicos = new List<String>();
                topicos.Add("");
                foreach (Topic topic in topics) {
                    topicos.Add(topic.DescTopic);
                }
                this.cbTopicos.DataSource = topicos;
            }

            if (localNote.Date != null)
            {
                this.txtbTitulo.Text = localNote.Name;
                this.txtbNota.Text = localNote.Description;

                if(topics.Count > 0)
                {
                    this.cbTopicos.SelectedIndex = auxTopicId;
                }
          
                this.txtbNota.ForeColor = SystemColors.WindowText;
            }
        }

        private void cbTopicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            localNote.Topic = cbTopicos.SelectedIndex;
        }
    }
}
