namespace PL
{
    partial class GameEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeTeamLabel = new System.Windows.Forms.Label();
            this.GuestTeamLabel = new System.Windows.Forms.Label();
            this.HomeTeamComboBox = new System.Windows.Forms.ComboBox();
            this.GuestTeamConboBox = new System.Windows.Forms.ComboBox();
            this.StadiumLabel = new System.Windows.Forms.Label();
            this.StadiumComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SpectatorsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.GameDateSelector = new System.Windows.Forms.DateTimePicker();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpectatorsTextBox = new System.Windows.Forms.TextBox();
            this.GameEditingLabel = new System.Windows.Forms.Label();
            this.HomeTeamScoreIncreaseButton = new System.Windows.Forms.Button();
            this.GuestTeamScoreIncreaseButton = new System.Windows.Forms.Button();
            this.GuestTeamScoreDecreaseButton = new System.Windows.Forms.Button();
            this.HomeTeamScoreDecreaseButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeTeamLabel
            // 
            this.HomeTeamLabel.AutoSize = true;
            this.HomeTeamLabel.Location = new System.Drawing.Point(52, 60);
            this.HomeTeamLabel.Name = "HomeTeamLabel";
            this.HomeTeamLabel.Size = new System.Drawing.Size(111, 15);
            this.HomeTeamLabel.TabIndex = 0;
            this.HomeTeamLabel.Text = "Домашня команда";
            // 
            // GuestTeamLabel
            // 
            this.GuestTeamLabel.AutoSize = true;
            this.GuestTeamLabel.Location = new System.Drawing.Point(462, 60);
            this.GuestTeamLabel.Name = "GuestTeamLabel";
            this.GuestTeamLabel.Size = new System.Drawing.Size(106, 15);
            this.GuestTeamLabel.TabIndex = 1;
            this.GuestTeamLabel.Text = "Гостьова команда";
            // 
            // HomeTeamComboBox
            // 
            this.HomeTeamComboBox.FormattingEnabled = true;
            this.HomeTeamComboBox.Location = new System.Drawing.Point(52, 78);
            this.HomeTeamComboBox.Name = "HomeTeamComboBox";
            this.HomeTeamComboBox.Size = new System.Drawing.Size(121, 23);
            this.HomeTeamComboBox.TabIndex = 2;
            this.HomeTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GuestTeamConboBox
            // 
            this.GuestTeamConboBox.FormattingEnabled = true;
            this.GuestTeamConboBox.Location = new System.Drawing.Point(447, 78);
            this.GuestTeamConboBox.Name = "GuestTeamConboBox";
            this.GuestTeamConboBox.Size = new System.Drawing.Size(121, 23);
            this.GuestTeamConboBox.TabIndex = 3;
            // 
            // StadiumLabel
            // 
            this.StadiumLabel.AutoSize = true;
            this.StadiumLabel.Location = new System.Drawing.Point(52, 273);
            this.StadiumLabel.Name = "StadiumLabel";
            this.StadiumLabel.Size = new System.Drawing.Size(49, 15);
            this.StadiumLabel.TabIndex = 4;
            this.StadiumLabel.Text = "Стадіон";
            // 
            // StadiumComboBox
            // 
            this.StadiumComboBox.FormattingEnabled = true;
            this.StadiumComboBox.Location = new System.Drawing.Point(52, 291);
            this.StadiumComboBox.Name = "StadiumComboBox";
            this.StadiumComboBox.Size = new System.Drawing.Size(121, 23);
            this.StadiumComboBox.TabIndex = 5;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(525, 273);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Статус";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(447, 291);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.StatusComboBox.TabIndex = 8;
            // 
            // SpectatorsLabel
            // 
            this.SpectatorsLabel.AutoSize = true;
            this.SpectatorsLabel.Location = new System.Drawing.Point(52, 342);
            this.SpectatorsLabel.Name = "SpectatorsLabel";
            this.SpectatorsLabel.Size = new System.Drawing.Size(105, 15);
            this.SpectatorsLabel.TabIndex = 9;
            this.SpectatorsLabel.Text = "Кількість глядачів";
            this.SpectatorsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(536, 333);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(32, 15);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Дата";
            // 
            // GameDateSelector
            // 
            this.GameDateSelector.Location = new System.Drawing.Point(447, 360);
            this.GameDateSelector.Name = "GameDateSelector";
            this.GameDateSelector.Size = new System.Drawing.Size(121, 23);
            this.GameDateSelector.TabIndex = 11;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(282, 189);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(52, 15);
            this.ScoreLabel.TabIndex = 12;
            this.ScoreLabel.Text = "Рахунок";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(52, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 136);
            this.label8.TabIndex = 13;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(447, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 136);
            this.label9.TabIndex = 14;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpectatorsTextBox
            // 
            this.SpectatorsTextBox.Location = new System.Drawing.Point(52, 360);
            this.SpectatorsTextBox.Name = "SpectatorsTextBox";
            this.SpectatorsTextBox.Size = new System.Drawing.Size(121, 23);
            this.SpectatorsTextBox.TabIndex = 15;
            // 
            // GameEditingLabel
            // 
            this.GameEditingLabel.AutoSize = true;
            this.GameEditingLabel.Location = new System.Drawing.Point(282, 22);
            this.GameEditingLabel.Name = "GameEditingLabel";
            this.GameEditingLabel.Size = new System.Drawing.Size(61, 15);
            this.GameEditingLabel.TabIndex = 16;
            this.GameEditingLabel.Text = "Зміна гри";
            this.GameEditingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeTeamScoreIncreaseButton
            // 
            this.HomeTeamScoreIncreaseButton.Location = new System.Drawing.Point(179, 184);
            this.HomeTeamScoreIncreaseButton.Name = "HomeTeamScoreIncreaseButton";
            this.HomeTeamScoreIncreaseButton.Size = new System.Drawing.Size(25, 25);
            this.HomeTeamScoreIncreaseButton.TabIndex = 17;
            this.HomeTeamScoreIncreaseButton.Text = "+";
            this.HomeTeamScoreIncreaseButton.UseVisualStyleBackColor = true;
            this.HomeTeamScoreIncreaseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuestTeamScoreIncreaseButton
            // 
            this.GuestTeamScoreIncreaseButton.Location = new System.Drawing.Point(416, 184);
            this.GuestTeamScoreIncreaseButton.Name = "GuestTeamScoreIncreaseButton";
            this.GuestTeamScoreIncreaseButton.Size = new System.Drawing.Size(25, 25);
            this.GuestTeamScoreIncreaseButton.TabIndex = 18;
            this.GuestTeamScoreIncreaseButton.Text = "+";
            this.GuestTeamScoreIncreaseButton.UseVisualStyleBackColor = true;
            this.GuestTeamScoreIncreaseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuestTeamScoreDecreaseButton
            // 
            this.GuestTeamScoreDecreaseButton.Location = new System.Drawing.Point(574, 184);
            this.GuestTeamScoreDecreaseButton.Name = "GuestTeamScoreDecreaseButton";
            this.GuestTeamScoreDecreaseButton.Size = new System.Drawing.Size(25, 25);
            this.GuestTeamScoreDecreaseButton.TabIndex = 19;
            this.GuestTeamScoreDecreaseButton.Text = "-";
            this.GuestTeamScoreDecreaseButton.UseVisualStyleBackColor = true;
            this.GuestTeamScoreDecreaseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // HomeTeamScoreDecreaseButton
            // 
            this.HomeTeamScoreDecreaseButton.Location = new System.Drawing.Point(21, 184);
            this.HomeTeamScoreDecreaseButton.Name = "HomeTeamScoreDecreaseButton";
            this.HomeTeamScoreDecreaseButton.Size = new System.Drawing.Size(25, 25);
            this.HomeTeamScoreDecreaseButton.TabIndex = 20;
            this.HomeTeamScoreDecreaseButton.Text = "-";
            this.HomeTeamScoreDecreaseButton.UseVisualStyleBackColor = true;
            this.HomeTeamScoreDecreaseButton.Visible = false;
            this.HomeTeamScoreDecreaseButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(246, 388);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(143, 36);
            this.SaveGameButton.TabIndex = 21;
            this.SaveGameButton.Text = "Зберегти зміни";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // GameEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.HomeTeamScoreDecreaseButton);
            this.Controls.Add(this.GuestTeamScoreDecreaseButton);
            this.Controls.Add(this.GuestTeamScoreIncreaseButton);
            this.Controls.Add(this.HomeTeamScoreIncreaseButton);
            this.Controls.Add(this.GameEditingLabel);
            this.Controls.Add(this.SpectatorsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameDateSelector);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SpectatorsLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StadiumComboBox);
            this.Controls.Add(this.StadiumLabel);
            this.Controls.Add(this.GuestTeamConboBox);
            this.Controls.Add(this.HomeTeamComboBox);
            this.Controls.Add(this.GuestTeamLabel);
            this.Controls.Add(this.HomeTeamLabel);
            this.Name = "GameEditing";
            this.Text = "Редагування гри";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HomeTeamLabel;
        private Label GuestTeamLabel;
        private ComboBox HomeTeamComboBox;
        private ComboBox GuestTeamConboBox;
        private Label StadiumLabel;
        private ComboBox StadiumComboBox;
        private Label StatusLabel;
        private ComboBox StatusComboBox;
        private Label SpectatorsLabel;
        private Label DateLabel;
        private DateTimePicker GameDateSelector;
        private Label ScoreLabel;
        private Label label8;
        private Label label9;
        private TextBox SpectatorsTextBox;
        private Label GameEditingLabel;
        private Button HomeTeamScoreIncreaseButton;
        private Button GuestTeamScoreIncreaseButton;
        private Button GuestTeamScoreDecreaseButton;
        private Button HomeTeamScoreDecreaseButton;
        private Button SaveGameButton;
    }
}