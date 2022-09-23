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
            Note note = new Note(1, "23/09/2022", 1, "nota", "uma nova nota");
            
                
            

            MessageBox.Show(note.Description);
            MessageBox.Show("Salvo com sucesso (sqn haha)");
        }
    }
}
