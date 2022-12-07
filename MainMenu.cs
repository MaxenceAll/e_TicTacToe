namespace e_TicTacToe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void start1j_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm(nameBoxJ1.Text,nameBoxJ2.Text,1);
            newGame.Show();

        }

        private void start2j_Click(object sender, EventArgs e)
        {

        }

    }
}