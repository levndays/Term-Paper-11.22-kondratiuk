namespace PL
{
    partial class TeamEditing
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
            this.PlayersList = new System.Windows.Forms.ListBox();
            this.AvailablePlayersLabel = new System.Windows.Forms.Label();
            this.MoveToTeamButton = new System.Windows.Forms.Button();
            this.GoalkeepersList = new System.Windows.Forms.ListBox();
            this.DefendersList = new System.Windows.Forms.ListBox();
            this.MiddlefieldersList = new System.Windows.Forms.ListBox();
            this.ForwardsList = new System.Windows.Forms.ListBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.GoalkeeperLabel = new System.Windows.Forms.Label();
            this.DefendersLabel = new System.Windows.Forms.Label();
            this.MiddlefieldersLabel = new System.Windows.Forms.Label();
            this.ForwardsLabel = new System.Windows.Forms.Label();
            this.GoalkeeperErrorLabel = new System.Windows.Forms.Label();
            this.MoveFromGoalkeepersButton = new System.Windows.Forms.Button();
            this.MoveFromDefendersButton = new System.Windows.Forms.Button();
            this.MoveFromMiddlefieldersButton = new System.Windows.Forms.Button();
            this.MoveFromForwardsButton = new System.Windows.Forms.Button();
            this.DefendersErrorLabel = new System.Windows.Forms.Label();
            this.MiddlefieldersErrorLabel = new System.Windows.Forms.Label();
            this.ForwardsErrorLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.ForwardsCountLabel = new System.Windows.Forms.Label();
            this.MiddlefieldersCountLabel = new System.Windows.Forms.Label();
            this.DefendersCountLabel = new System.Windows.Forms.Label();
            this.GoalkeeperCountLabel = new System.Windows.Forms.Label();
            this.PlayersInTeamCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayersList
            // 
            this.PlayersList.FormattingEnabled = true;
            this.PlayersList.ItemHeight = 15;
            this.PlayersList.Location = new System.Drawing.Point(12, 59);
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(273, 544);
            this.PlayersList.TabIndex = 1;
            // 
            // AvailablePlayersLabel
            // 
            this.AvailablePlayersLabel.AutoSize = true;
            this.AvailablePlayersLabel.Location = new System.Drawing.Point(12, 31);
            this.AvailablePlayersLabel.Name = "AvailablePlayersLabel";
            this.AvailablePlayersLabel.Size = new System.Drawing.Size(93, 15);
            this.AvailablePlayersLabel.TabIndex = 2;
            this.AvailablePlayersLabel.Text = "Доступні гравці";
            // 
            // MoveToTeamButton
            // 
            this.MoveToTeamButton.Location = new System.Drawing.Point(306, 242);
            this.MoveToTeamButton.Name = "MoveToTeamButton";
            this.MoveToTeamButton.Size = new System.Drawing.Size(50, 50);
            this.MoveToTeamButton.TabIndex = 3;
            this.MoveToTeamButton.Text = "=>";
            this.MoveToTeamButton.UseVisualStyleBackColor = true;
            this.MoveToTeamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoalkeepersList
            // 
            this.GoalkeepersList.FormattingEnabled = true;
            this.GoalkeepersList.ItemHeight = 15;
            this.GoalkeepersList.Location = new System.Drawing.Point(385, 59);
            this.GoalkeepersList.Name = "GoalkeepersList";
            this.GoalkeepersList.Size = new System.Drawing.Size(367, 64);
            this.GoalkeepersList.TabIndex = 4;
            // 
            // DefendersList
            // 
            this.DefendersList.FormattingEnabled = true;
            this.DefendersList.ItemHeight = 15;
            this.DefendersList.Location = new System.Drawing.Point(385, 178);
            this.DefendersList.Name = "DefendersList";
            this.DefendersList.Size = new System.Drawing.Size(367, 79);
            this.DefendersList.TabIndex = 5;
            // 
            // MiddlefieldersList
            // 
            this.MiddlefieldersList.FormattingEnabled = true;
            this.MiddlefieldersList.ItemHeight = 15;
            this.MiddlefieldersList.Location = new System.Drawing.Point(385, 318);
            this.MiddlefieldersList.Name = "MiddlefieldersList";
            this.MiddlefieldersList.Size = new System.Drawing.Size(367, 79);
            this.MiddlefieldersList.TabIndex = 6;
            // 
            // ForwardsList
            // 
            this.ForwardsList.FormattingEnabled = true;
            this.ForwardsList.ItemHeight = 15;
            this.ForwardsList.Location = new System.Drawing.Point(385, 449);
            this.ForwardsList.Name = "ForwardsList";
            this.ForwardsList.Size = new System.Drawing.Size(367, 79);
            this.ForwardsList.TabIndex = 7;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(385, 621);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(367, 51);
            this.SaveChangesButton.TabIndex = 8;
            this.SaveChangesButton.Text = "Сформувати команду";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GoalkeeperLabel
            // 
            this.GoalkeeperLabel.AutoSize = true;
            this.GoalkeeperLabel.Location = new System.Drawing.Point(385, 38);
            this.GoalkeeperLabel.Name = "GoalkeeperLabel";
            this.GoalkeeperLabel.Size = new System.Drawing.Size(53, 15);
            this.GoalkeeperLabel.TabIndex = 9;
            this.GoalkeeperLabel.Text = "Воротар";
            // 
            // DefendersLabel
            // 
            this.DefendersLabel.AutoSize = true;
            this.DefendersLabel.Location = new System.Drawing.Point(385, 151);
            this.DefendersLabel.Name = "DefendersLabel";
            this.DefendersLabel.Size = new System.Drawing.Size(66, 15);
            this.DefendersLabel.TabIndex = 10;
            this.DefendersLabel.Text = "Захисники";
            // 
            // MiddlefieldersLabel
            // 
            this.MiddlefieldersLabel.AutoSize = true;
            this.MiddlefieldersLabel.Location = new System.Drawing.Point(385, 289);
            this.MiddlefieldersLabel.Name = "MiddlefieldersLabel";
            this.MiddlefieldersLabel.Size = new System.Drawing.Size(95, 15);
            this.MiddlefieldersLabel.TabIndex = 11;
            this.MiddlefieldersLabel.Text = "Напівзахисники";
            // 
            // ForwardsLabel
            // 
            this.ForwardsLabel.AutoSize = true;
            this.ForwardsLabel.Location = new System.Drawing.Point(385, 425);
            this.ForwardsLabel.Name = "ForwardsLabel";
            this.ForwardsLabel.Size = new System.Drawing.Size(62, 15);
            this.ForwardsLabel.TabIndex = 12;
            this.ForwardsLabel.Text = "Форварди";
            // 
            // GoalkeeperErrorLabel
            // 
            this.GoalkeeperErrorLabel.AutoSize = true;
            this.GoalkeeperErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.GoalkeeperErrorLabel.Location = new System.Drawing.Point(385, 126);
            this.GoalkeeperErrorLabel.Name = "GoalkeeperErrorLabel";
            this.GoalkeeperErrorLabel.Size = new System.Drawing.Size(314, 15);
            this.GoalkeeperErrorLabel.TabIndex = 13;
            this.GoalkeeperErrorLabel.Text = "Максимально можлива кількість гравців на цій позиції!";
            this.GoalkeeperErrorLabel.UseMnemonic = false;
            this.GoalkeeperErrorLabel.Visible = false;
            // 
            // MoveFromGoalkeepersButton
            // 
            this.MoveFromGoalkeepersButton.Location = new System.Drawing.Point(702, 31);
            this.MoveFromGoalkeepersButton.Name = "MoveFromGoalkeepersButton";
            this.MoveFromGoalkeepersButton.Size = new System.Drawing.Size(50, 22);
            this.MoveFromGoalkeepersButton.TabIndex = 14;
            this.MoveFromGoalkeepersButton.Text = "<=";
            this.MoveFromGoalkeepersButton.UseVisualStyleBackColor = true;
            this.MoveFromGoalkeepersButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MoveFromDefendersButton
            // 
            this.MoveFromDefendersButton.Location = new System.Drawing.Point(702, 151);
            this.MoveFromDefendersButton.Name = "MoveFromDefendersButton";
            this.MoveFromDefendersButton.Size = new System.Drawing.Size(50, 22);
            this.MoveFromDefendersButton.TabIndex = 15;
            this.MoveFromDefendersButton.Text = "<=";
            this.MoveFromDefendersButton.UseVisualStyleBackColor = true;
            this.MoveFromDefendersButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MoveFromMiddlefieldersButton
            // 
            this.MoveFromMiddlefieldersButton.Location = new System.Drawing.Point(702, 290);
            this.MoveFromMiddlefieldersButton.Name = "MoveFromMiddlefieldersButton";
            this.MoveFromMiddlefieldersButton.Size = new System.Drawing.Size(50, 22);
            this.MoveFromMiddlefieldersButton.TabIndex = 16;
            this.MoveFromMiddlefieldersButton.Text = "<=";
            this.MoveFromMiddlefieldersButton.UseVisualStyleBackColor = true;
            this.MoveFromMiddlefieldersButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // MoveFromForwardsButton
            // 
            this.MoveFromForwardsButton.Location = new System.Drawing.Point(702, 421);
            this.MoveFromForwardsButton.Name = "MoveFromForwardsButton";
            this.MoveFromForwardsButton.Size = new System.Drawing.Size(50, 22);
            this.MoveFromForwardsButton.TabIndex = 17;
            this.MoveFromForwardsButton.Text = "<=";
            this.MoveFromForwardsButton.UseVisualStyleBackColor = true;
            this.MoveFromForwardsButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // DefendersErrorLabel
            // 
            this.DefendersErrorLabel.AutoSize = true;
            this.DefendersErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DefendersErrorLabel.Location = new System.Drawing.Point(385, 260);
            this.DefendersErrorLabel.Name = "DefendersErrorLabel";
            this.DefendersErrorLabel.Size = new System.Drawing.Size(314, 15);
            this.DefendersErrorLabel.TabIndex = 18;
            this.DefendersErrorLabel.Text = "Максимально можлива кількість гравців на цій позиції!";
            this.DefendersErrorLabel.UseMnemonic = false;
            this.DefendersErrorLabel.Visible = false;
            // 
            // MiddlefieldersErrorLabel
            // 
            this.MiddlefieldersErrorLabel.AutoSize = true;
            this.MiddlefieldersErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MiddlefieldersErrorLabel.Location = new System.Drawing.Point(385, 400);
            this.MiddlefieldersErrorLabel.Name = "MiddlefieldersErrorLabel";
            this.MiddlefieldersErrorLabel.Size = new System.Drawing.Size(314, 15);
            this.MiddlefieldersErrorLabel.TabIndex = 19;
            this.MiddlefieldersErrorLabel.Text = "Максимально можлива кількість гравців на цій позиції!";
            this.MiddlefieldersErrorLabel.UseMnemonic = false;
            this.MiddlefieldersErrorLabel.Visible = false;
            // 
            // ForwardsErrorLabel
            // 
            this.ForwardsErrorLabel.AutoSize = true;
            this.ForwardsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ForwardsErrorLabel.Location = new System.Drawing.Point(385, 531);
            this.ForwardsErrorLabel.Name = "ForwardsErrorLabel";
            this.ForwardsErrorLabel.Size = new System.Drawing.Size(314, 15);
            this.ForwardsErrorLabel.TabIndex = 20;
            this.ForwardsErrorLabel.Text = "Максимально можлива кількість гравців на цій позиції!";
            this.ForwardsErrorLabel.UseMnemonic = false;
            this.ForwardsErrorLabel.Visible = false;
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(385, 580);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(366, 23);
            this.TeamNameTextBox.TabIndex = 21;
            this.TeamNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Location = new System.Drawing.Point(385, 562);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(90, 15);
            this.TeamNameLabel.TabIndex = 22;
            this.TeamNameLabel.Text = "Назва команди";
            // 
            // ForwardsCountLabel
            // 
            this.ForwardsCountLabel.AutoSize = true;
            this.ForwardsCountLabel.Location = new System.Drawing.Point(671, 425);
            this.ForwardsCountLabel.Name = "ForwardsCountLabel";
            this.ForwardsCountLabel.Size = new System.Drawing.Size(25, 15);
            this.ForwardsCountLabel.TabIndex = 23;
            this.ForwardsCountLabel.Text = "X/3";
            // 
            // MiddlefieldersCountLabel
            // 
            this.MiddlefieldersCountLabel.AutoSize = true;
            this.MiddlefieldersCountLabel.Location = new System.Drawing.Point(671, 294);
            this.MiddlefieldersCountLabel.Name = "MiddlefieldersCountLabel";
            this.MiddlefieldersCountLabel.Size = new System.Drawing.Size(26, 15);
            this.MiddlefieldersCountLabel.TabIndex = 24;
            this.MiddlefieldersCountLabel.Text = "X/X";
            this.MiddlefieldersCountLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // DefendersCountLabel
            // 
            this.DefendersCountLabel.AutoSize = true;
            this.DefendersCountLabel.Location = new System.Drawing.Point(671, 155);
            this.DefendersCountLabel.Name = "DefendersCountLabel";
            this.DefendersCountLabel.Size = new System.Drawing.Size(25, 15);
            this.DefendersCountLabel.TabIndex = 25;
            this.DefendersCountLabel.Text = "X/5";
            // 
            // GoalkeeperCountLabel
            // 
            this.GoalkeeperCountLabel.AutoSize = true;
            this.GoalkeeperCountLabel.Location = new System.Drawing.Point(671, 35);
            this.GoalkeeperCountLabel.Name = "GoalkeeperCountLabel";
            this.GoalkeeperCountLabel.Size = new System.Drawing.Size(25, 15);
            this.GoalkeeperCountLabel.TabIndex = 26;
            this.GoalkeeperCountLabel.Text = "X/1";
            // 
            // PlayersInTeamCountLabel
            // 
            this.PlayersInTeamCountLabel.AutoSize = true;
            this.PlayersInTeamCountLabel.Location = new System.Drawing.Point(318, 318);
            this.PlayersInTeamCountLabel.Name = "PlayersInTeamCountLabel";
            this.PlayersInTeamCountLabel.Size = new System.Drawing.Size(30, 15);
            this.PlayersInTeamCountLabel.TabIndex = 27;
            this.PlayersInTeamCountLabel.Text = "0/11";
            // 
            // TeamEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 688);
            this.Controls.Add(this.PlayersInTeamCountLabel);
            this.Controls.Add(this.GoalkeeperCountLabel);
            this.Controls.Add(this.DefendersCountLabel);
            this.Controls.Add(this.MiddlefieldersCountLabel);
            this.Controls.Add(this.ForwardsCountLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.ForwardsErrorLabel);
            this.Controls.Add(this.MiddlefieldersErrorLabel);
            this.Controls.Add(this.DefendersErrorLabel);
            this.Controls.Add(this.MoveFromForwardsButton);
            this.Controls.Add(this.MoveFromMiddlefieldersButton);
            this.Controls.Add(this.MoveFromDefendersButton);
            this.Controls.Add(this.MoveFromGoalkeepersButton);
            this.Controls.Add(this.GoalkeeperErrorLabel);
            this.Controls.Add(this.ForwardsLabel);
            this.Controls.Add(this.MiddlefieldersLabel);
            this.Controls.Add(this.DefendersLabel);
            this.Controls.Add(this.GoalkeeperLabel);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.ForwardsList);
            this.Controls.Add(this.MiddlefieldersList);
            this.Controls.Add(this.DefendersList);
            this.Controls.Add(this.GoalkeepersList);
            this.Controls.Add(this.MoveToTeamButton);
            this.Controls.Add(this.AvailablePlayersLabel);
            this.Controls.Add(this.PlayersList);
            this.Name = "TeamEditing";
            this.Text = "Зміна команди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PlayersList;
        private Label AvailablePlayersLabel;
        private Button MoveToTeamButton;
        private ListBox GoalkeepersList;
        private ListBox DefendersList;
        private ListBox MiddlefieldersList;
        private ListBox ForwardsList;
        private Button SaveChangesButton;
        private Label GoalkeeperLabel;
        private Label DefendersLabel;
        private Label MiddlefieldersLabel;
        private Label ForwardsLabel;
        private Label GoalkeeperErrorLabel;
        private Button MoveFromGoalkeepersButton;
        private Button MoveFromDefendersButton;
        private Button MoveFromMiddlefieldersButton;
        private Button MoveFromForwardsButton;
        private Label DefendersErrorLabel;
        private Label MiddlefieldersErrorLabel;
        private Label ForwardsErrorLabel;
        private TextBox TeamNameTextBox;
        private Label TeamNameLabel;
        private Label ForwardsCountLabel;
        private Label MiddlefieldersCountLabel;
        private Label DefendersCountLabel;
        private Label GoalkeeperCountLabel;
        private Label PlayersInTeamCountLabel;
    }
}