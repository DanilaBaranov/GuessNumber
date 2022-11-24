namespace Guess_Number {
    partial class Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Current_Number = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Score_text = new System.Windows.Forms.TextBox();
            this.Lives_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tries_min_text = new System.Windows.Forms.TextBox();
            this.Tries_max_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tries_avg_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tries_g_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tries_l_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Info_text = new System.Windows.Forms.TextBox();
            this.usedNums_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your number:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Current_Number
            // 
            this.Current_Number.Location = new System.Drawing.Point(91, 22);
            this.Current_Number.Name = "Current_Number";
            this.Current_Number.Size = new System.Drawing.Size(100, 23);
            this.Current_Number.TabIndex = 4;
            this.Current_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Current_Number_KeyPress);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(197, 22);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 5;
            this.Update.Text = "Enter";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Score_text
            // 
            this.Score_text.Location = new System.Drawing.Point(85, 22);
            this.Score_text.Name = "Score_text";
            this.Score_text.ReadOnly = true;
            this.Score_text.Size = new System.Drawing.Size(100, 23);
            this.Score_text.TabIndex = 6;
            // 
            // Lives_text
            // 
            this.Lives_text.Location = new System.Drawing.Point(85, 51);
            this.Lives_text.Name = "Lives_text";
            this.Lives_text.ReadOnly = true;
            this.Lives_text.Size = new System.Drawing.Size(100, 23);
            this.Lives_text.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Tries_min_text);
            this.groupBox1.Controls.Add(this.Tries_max_text);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Tries_avg_text);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tries_g_text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tries_l_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Score_text);
            this.groupBox1.Controls.Add(this.Lives_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(303, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Min Tries";
            // 
            // Tries_min_text
            // 
            this.Tries_min_text.Location = new System.Drawing.Point(85, 196);
            this.Tries_min_text.Name = "Tries_min_text";
            this.Tries_min_text.ReadOnly = true;
            this.Tries_min_text.Size = new System.Drawing.Size(100, 23);
            this.Tries_min_text.TabIndex = 16;
            // 
            // Tries_max_text
            // 
            this.Tries_max_text.Location = new System.Drawing.Point(85, 167);
            this.Tries_max_text.Name = "Tries_max_text";
            this.Tries_max_text.ReadOnly = true;
            this.Tries_max_text.Size = new System.Drawing.Size(100, 23);
            this.Tries_max_text.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Max Tries";
            // 
            // Tries_avg_text
            // 
            this.Tries_avg_text.Location = new System.Drawing.Point(85, 138);
            this.Tries_avg_text.Name = "Tries_avg_text";
            this.Tries_avg_text.ReadOnly = true;
            this.Tries_avg_text.Size = new System.Drawing.Size(100, 23);
            this.Tries_avg_text.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "AVG Tries";
            // 
            // Tries_g_text
            // 
            this.Tries_g_text.Location = new System.Drawing.Point(85, 109);
            this.Tries_g_text.Name = "Tries_g_text";
            this.Tries_g_text.ReadOnly = true;
            this.Tries_g_text.Size = new System.Drawing.Size(100, 23);
            this.Tries_g_text.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tries(global)";
            // 
            // Tries_l_text
            // 
            this.Tries_l_text.Location = new System.Drawing.Point(85, 80);
            this.Tries_l_text.Name = "Tries_l_text";
            this.Tries_l_text.ReadOnly = true;
            this.Tries_l_text.Size = new System.Drawing.Size(100, 23);
            this.Tries_l_text.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tries(local)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Current_Number);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Info_text
            // 
            this.Info_text.Location = new System.Drawing.Point(12, 90);
            this.Info_text.Name = "Info_text";
            this.Info_text.PlaceholderText = "Type number between 1 and 100 and push \"Enter\"";
            this.Info_text.ReadOnly = true;
            this.Info_text.Size = new System.Drawing.Size(285, 23);
            this.Info_text.TabIndex = 10;
            // 
            // usedNums_text
            // 
            this.usedNums_text.Location = new System.Drawing.Point(54, 119);
            this.usedNums_text.Multiline = true;
            this.usedNums_text.Name = "usedNums_text";
            this.usedNums_text.PlaceholderText = "Here will be printed last entered numbers";
            this.usedNums_text.ReadOnly = true;
            this.usedNums_text.Size = new System.Drawing.Size(243, 43);
            this.usedNums_text.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Used:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usedNums_text);
            this.Controls.Add(this.Info_text);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Guess Number";
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox Current_Number;
        private Button Update;
        private TextBox Score_text;
        private TextBox Lives_text;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Info_text;
        private TextBox Tries_l_text;
        private Label label4;
        private TextBox usedNums_text;
        private Label label5;
        private Label label6;
        private TextBox Tries_g_text;
        private Label label7;
        private TextBox Tries_avg_text;
        private TextBox Tries_min_text;
        private TextBox Tries_max_text;
        private Label label8;
        private Label label9;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}