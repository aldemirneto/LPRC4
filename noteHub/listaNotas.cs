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
    public partial class listaNotas : Form
    {
        public listaNotas()
        {
            InitializeComponent();
        }

        private void listaNotas_Load(object sender, EventArgs e)
        {
            List<Note> minhasNotas = new List<Note>();
            Note note1 = new Note(1, "23/09/2022", 1, "Nota do Lucas", "uma nova nota do Lucas");
            minhasNotas.Add(note1);
            Note note2 = new Note(1, "23/09/2022", 1, "Nota do Gabryel", "uma nova nota do Gabryel");
            minhasNotas.Add(note2);
            Note note3 = new Note(1, "23/09/2022", 1, "Nota do Danilo", "uma nova nota do Danilo");
            minhasNotas.Add(note3);
            this.DGV_Lista_de_Notas.DataSource = minhasNotas;
           


        }
    }
}
    