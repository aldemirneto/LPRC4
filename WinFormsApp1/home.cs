namespace WinFormsApp1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void EditUser(object sender, EventArgs e)
        {
            this.Hide();
            atualizar e1 = new();
            e1.Show();
        }

        private void NewNote(object sender, EventArgs e)
        {
            this.Hide();
            ediçao e1 = new();
            e1.Show();
        }
    }
}