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
        public List<Note> minhasNotas;
        public List<Topic> topics;

        public listaNotas()
        {
            InitializeComponent();
        }

        private void listaNotas_Load(object sender, EventArgs e)
        {
            if (this.minhasNotas.Count > 0)
            {
                this.DGV_Lista_de_Notas.DataSource = this.minhasNotas;            
            }else
            {
                this.DGV_Lista_de_Notas.DataSource = "";
            }
        }

        private void DGV_Lista_de_Notas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            criarNota myCriarNota = new criarNota();
            myCriarNota.localNote = minhasNotas[e.RowIndex];
            myCriarNota.notes = minhasNotas;
            myCriarNota.id = e.RowIndex;
            myCriarNota.topics = this.topics;
            myCriarNota.MdiParent = this.MdiParent;
            myCriarNota.Show();
        }
    }
}
    