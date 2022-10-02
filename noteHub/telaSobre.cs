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
    public partial class telaSobre : Form
    {
        public telaSobre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telaSobre_Load(object sender, EventArgs e)
        {
            this.lbSobre.Text = "" +
                "“NoteHub” consiste em um aplicativo desktop implementado\n" +
                " na linguagem C# e com Windows Forms. A solução se propõe\n" +
                " a ser um serviço de gerenciamento de anotações acadêmicas\n" +
                " em que o usuário cria tópicos baseados nas matérias que está\n" +
                " cursando e cria notas de aula dentro de cada tópico.\n" +
                "\r\n\r\nA solução foi dividida em 3 projetos: o projeto Windows Forms,\n" +
                " uma Class Library chamada DAO e outra Class Library\n chamada Classes." +
                "\r\n\r\nA solução não conta com persistência de dados. No entanto,\n" +
                "a estrutura de persistência está implementado na Class Library\n DAO." +
                "O banco escolhido pelo grupo foi o MySql.\n\n" +
                "Grupo: Gabryel Bueno da Silva, Danilo Quaggio, Aldemir\n" +
                "Humberto Soares Neto, Lucas Fiori Rosa e Lucas Gomes.\n" +
                "\nDivirta-se! :)";
        }
    }
}
