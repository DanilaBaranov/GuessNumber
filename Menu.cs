namespace Guess_Number {
    enum diffs {Easy = 1, Medium = 2, Hard = 3}

    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();

            Difficulty_Choice.DataSource = Enum.GetValues(typeof(diffs));
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            Game game = new Game(Convert.ToInt32(Difficulty_Choice.SelectedValue), false);

            this.Hide();

            game.ShowDialog();

            this.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "JSON Files|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                Game game = new Game(Convert.ToInt32(Difficulty_Choice.SelectedValue), true, openFileDialog.FileName);

                this.Hide();

                game.ShowDialog();

                this.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to exit the game?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Difficulty_Choice_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case (char)Keys.Enter:
                    startToolStripMenuItem.PerformClick();

                    break;

                case (char)Keys.Escape:
                    exitToolStripMenuItem.PerformClick();

                    break;
            }
        }
    }
}