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
        public criarNota()
        {
            InitializeComponent();
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso (sqn haha)");
        }
    }
}
