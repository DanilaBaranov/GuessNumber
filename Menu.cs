namespace Guess_Number {
    enum diffs {easy = 1, medium = 2, hard = 3 }
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();

            Difficulty_Choice.DataSource = Enum.GetValues(typeof(diffs));
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            Game game = new Game(Convert.ToInt32(Difficulty_Choice.SelectedValue));

            this.Hide();

            game.ShowDialog();

            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}