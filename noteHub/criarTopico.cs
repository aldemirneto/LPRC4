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
    public partial class criarTopico : Form
    {
        public List<Topic> topics;
        public Topic localTopic = new Topic();

        public criarTopico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (localTopic.DescTopic != null && localTopic.DescTopic != "")
            {
                if (topics.Count > 0)
                {
                    Topic last;
                    last = topics.Last();
                    localTopic.IDTopic = last.IDTopic + 1;
                }
                else
                {
                    localTopic.IDTopic = 1;
                }
                topics.Add(localTopic);
                localTopic = new Topic();
                this.tbTopico.Text = null;
                this.ActiveControl = tbTopico;
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Por favor, preencha o nome do tópico.");
            }
        }

        private void tbTopico_TextChanged(object sender, EventArgs e)
        {
            this.localTopic.DescTopic = tbTopico.Text;
        }
    }
}
