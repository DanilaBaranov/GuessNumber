using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Guess_Number {
    public partial class Game : Form {
        int lives,

            tries_global = 0,
            tries_local = 0,
            avg_tries = 0,
            max_tries = 0,
            min_tries = 100,
            
            score = 0,
            
            delta,
            
            win_num;

        string
            fileName = "GameSave.json",
            JSON_Str,
            
            info = "",
            usedNums = "";

        bool
            isGameSaved = false;

        DialogResult result;

        Random rnd = new Random();

        public Game(int difficulty, bool isLoadGame, string _fileName = "") {
            InitializeComponent();
            
            switch (difficulty) {
                case 1:
                    lives = 10;
                    delta = 8;

                    this.Text = $"{this.Text}-Easy";
                    
                    break;

                case 2:
                    lives = 8;
                    delta = 7;

                    this.Text = $"{this.Text}-Medium";

                    break;

                case 3:
                    lives = 6;
                    delta = 5;
                    this.Text = $"{this.Text}-Hard";

                    break;
            }

            Lives_text.Text = lives.ToString();
            Score_text.Text = score.ToString();

            Tries_l_text.Text = tries_local.ToString();
            Tries_g_text.Text = tries_global.ToString();

            Tries_avg_text.Text = avg_tries.ToString();
            Tries_max_text.Text = max_tries.ToString();
            Tries_min_text.Text = "0";

            win_num = rnd.Next(1,100);

            if (isLoadGame) {
                fileName = _fileName;
                loadToolStripMenuItem.PerformClick();
            }
        }
        private void Current_Number_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case (char)Keys.Enter:
                    Update.PerformClick();
                    isGameSaved = false;

                    break;

                case (char)Keys.Escape:
                    exitToolStripMenuItem.PerformClick();

                    break;
            }
        }

        private void Update_Click(object sender, EventArgs e) {
            int number = 0;

            try {
                number = Convert.ToInt32(Current_Number.Text);
            } catch (System.FormatException) {
                Current_Number.Clear();
                Current_Number.Focus();
                
                return;
            }

            if ((number < 1)) {
                MessageBox.Show($"Your number: {number} < 1");

                Current_Number.Clear();
                Current_Number.Focus();

                return;
            } 
            else if (number > 100) {
                MessageBox.Show($"Your number: {number} > 100");

                Current_Number.Clear();
                Current_Number.Focus();

                return;
            }
            
            if (number == win_num) {
                ++score;
                lives += delta;

                ++tries_local;
                ++tries_global;

                max_tries = tries_local > max_tries ? tries_local : max_tries;
                
                min_tries = tries_local < min_tries ? tries_local : min_tries;
                
                tries_local = 0;

                Info_text.Clear();
                usedNums_text.Clear();

                MessageBox.Show($"Your number: {number} is correct. \r\nGenerating new number");

                win_num = rnd.Next(1, 100);
            } else if (number > win_num) {
                ++tries_local;
                ++tries_global;

                --lives;

                usedNums_text.Text += $" {number}(>)";

                Info_text.Text = $"Your number: {number} is bigger";
            } else if (number < win_num) {
                ++tries_local;
                ++tries_global;

                --lives;

                usedNums_text.Text += $" {number}(<)";

                Info_text.Text = $"Your number: {number} is smaller";
            }

            Score_text.Text = score.ToString();
            Lives_text.Text = lives.ToString();

            Tries_l_text.Text = tries_local.ToString();
            Tries_g_text.Text = tries_global.ToString();

            Tries_avg_text.Text = score == 0 ? 0.ToString() : (tries_global / score).ToString();
            Tries_max_text.Text = max_tries.ToString();
            if (min_tries != 100)
                Tries_min_text.Text = min_tries.ToString();

            if (lives == 0) {
                min_tries = min_tries == 100 ? 0 : min_tries;

                MessageBox.Show(
                    $"You loose. \r\n\r\nScore: {score} \r\nLives: {lives} \r\nTries(local): " +
                    $"{tries_local} \r\nTries(global): {tries_global}" +
                    $"\r\nTries(AVG): {avg_tries} \r\nTries(max): {max_tries} \r\n Tries(min): {min_tries}"
                    ,
                    "Game over", MessageBoxButtons.OK);

                this.Close();
            }

            Current_Number.Clear();
            Current_Number.Focus();
        }

        private void Game_Shown(object sender, EventArgs e) {
            Current_Number.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            fileName = "GameSave.json";

            info = Info_text.Text;
            usedNums = usedNums_text.Text;

            GameStatus status = new GameStatus(lives, tries_global, tries_local, avg_tries, max_tries, min_tries, score, info, usedNums);


            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "JSON Files|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                JSON_Str = JsonConvert.SerializeObject(status);

                fileName = saveFileDialog.FileName;

                File.WriteAllText(fileName, JSON_Str);

                isGameSaved = true;
            }
        }

        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog.FileName = fileName;
            openFileDialog.Filter = "JSON Files|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;

                JSON_Str = File.ReadAllText(fileName);

                GameStatus status = JsonConvert.DeserializeObject<GameStatus>(JSON_Str);

                lives = status.lives;
                Lives_text.Text = lives.ToString();
                score = status.score;
                Score_text.Text = score.ToString();

                tries_local = status.tries_local;
                Tries_l_text.Text = tries_local.ToString();
                tries_global = status.tries_global;
                Tries_g_text.Text = tries_global.ToString();

                avg_tries = status.avg_tries;
                Tries_avg_text.Text = avg_tries.ToString();
                max_tries = status.max_tries;
                Tries_max_text.Text = max_tries.ToString();
                min_tries = status.min_tries;
                Tries_min_text.Text = min_tries.ToString();

                info = status.info;
                Info_text.Text = info;
                usedNums = status.usedNums;
                usedNums_text.Text = usedNums;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (isGameSaved)
                result = MessageBox.Show("Do you want to return to the Menu?", "Game", MessageBoxButtons.YesNoCancel);
            else
                result = MessageBox.Show("Exit without saving?", "Game", MessageBoxButtons.YesNoCancel);
                

                switch (result) {
                    case DialogResult.Yes:
                        this.Close();

                        break;

                    case DialogResult.No:
                        if (!isGameSaved)
                            saveToolStripMenuItem.PerformClick();
                        
                        break;

                    case DialogResult.Cancel:
                        return;
                }
        }
    }
}