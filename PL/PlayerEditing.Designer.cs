namespace PL
{
    partial class PlayerEditing
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.UnavailableRadioButton = new System.Windows.Forms.RadioButton();
            this.AvailableRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthGroupBox = new System.Windows.Forms.GroupBox();
            this.TraumaRadioButton = new System.Windows.Forms.RadioButton();
            this.MinorTraumaRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.NameSurnameErrorLabel = new System.Windows.Forms.Label();
            this.DateOfBirthSelector = new System.Windows.Forms.DateTimePicker();
            this.PositionGroupBox = new System.Windows.Forms.GroupBox();
            this.ForwardRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddlefielderRadioButton = new System.Windows.Forms.RadioButton();
            this.DefenderRadioButton = new System.Windows.Forms.RadioButton();
            this.GoalkeeperRadioButton = new System.Windows.Forms.RadioButton();
            this.StatusGroupBox.SuspendLayout();
            this.HealthGroupBox.SuspendLayout();
            this.PositionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(28, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Ім\'я";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(274, 26);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(61, 15);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Прізвище";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(12, 44);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(158, 23);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(274, 44);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(12, 115);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(103, 15);
            this.DateOfBirthLabel.TabIndex = 5;
            this.DateOfBirthLabel.Text = "Дата народження";
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.UnavailableRadioButton);
            this.StatusGroupBox.Controls.Add(this.AvailableRadioButton);
            this.StatusGroupBox.Location = new System.Drawing.Point(12, 138);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(175, 162);
            this.StatusGroupBox.TabIndex = 8;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Статус";
            // 
            // UnavailableRadioButton
            // 
            this.UnavailableRadioButton.AutoSize = true;
            this.UnavailableRadioButton.Location = new System.Drawing.Point(9, 47);
            this.UnavailableRadioButton.Name = "UnavailableRadioButton";
            this.UnavailableRadioButton.Size = new System.Drawing.Size(142, 19);
            this.UnavailableRadioButton.TabIndex = 1;
            this.UnavailableRadioButton.Text = "Недоступний для гри";
            this.UnavailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // AvailableRadioButton
            // 
            this.AvailableRadioButton.AutoSize = true;
            this.AvailableRadioButton.Location = new System.Drawing.Point(9, 22);
            this.AvailableRadioButton.Name = "AvailableRadioButton";
            this.AvailableRadioButton.Size = new System.Drawing.Size(129, 19);
            this.AvailableRadioButton.TabIndex = 0;
            this.AvailableRadioButton.Text = "Доступний для гри";
            this.AvailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // HealthGroupBox
            // 
            this.HealthGroupBox.Controls.Add(this.TraumaRadioButton);
            this.HealthGroupBox.Controls.Add(this.MinorTraumaRadioButton);
            this.HealthGroupBox.Controls.Add(this.HealthyRadioButton);
            this.HealthGroupBox.Location = new System.Drawing.Point(196, 138);
            this.HealthGroupBox.Name = "HealthGroupBox";
            this.HealthGroupBox.Size = new System.Drawing.Size(166, 162);
            this.HealthGroupBox.TabIndex = 9;
            this.HealthGroupBox.TabStop = false;
            this.HealthGroupBox.Text = "Стан здоров\'я";
            // 
            // TraumaRadioButton
            // 
            this.TraumaRadioButton.AutoSize = true;
            this.TraumaRadioButton.Location = new System.Drawing.Point(6, 72);
            this.TraumaRadioButton.Name = "TraumaRadioButton";
            this.TraumaRadioButton.Size = new System.Drawing.Size(99, 19);
            this.TraumaRadioButton.TabIndex = 4;
            this.TraumaRadioButton.Text = "Травмований";
            this.TraumaRadioButton.UseVisualStyleBackColor = true;
            // 
            // MinorTraumaRadioButton
            // 
            this.MinorTraumaRadioButton.AutoSize = true;
            this.MinorTraumaRadioButton.Location = new System.Drawing.Point(6, 47);
            this.MinorTraumaRadioButton.Name = "MinorTraumaRadioButton";
            this.MinorTraumaRadioButton.Size = new System.Drawing.Size(118, 19);
            this.MinorTraumaRadioButton.TabIndex = 3;
            this.MinorTraumaRadioButton.Text = "Незначні травми";
            this.MinorTraumaRadioButton.UseVisualStyleBackColor = true;
            // 
            // HealthyRadioButton
            // 
            this.HealthyRadioButton.AutoSize = true;
            this.HealthyRadioButton.Location = new System.Drawing.Point(6, 22);
            this.HealthyRadioButton.Name = "HealthyRadioButton";
            this.HealthyRadioButton.Size = new System.Drawing.Size(79, 19);
            this.HealthyRadioButton.TabIndex = 2;
            this.HealthyRadioButton.Text = "Здоровий";
            this.HealthyRadioButton.UseVisualStyleBackColor = true;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(377, 329);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(161, 23);
            this.SalaryTextBox.TabIndex = 10;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(377, 311);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(96, 15);
            this.SalaryLabel.TabIndex = 11;
            this.SalaryLabel.Text = "Заробітня плата";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(380, 390);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(158, 37);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Зберегти зміни";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(380, 355);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(121, 15);
            this.ErrorLabel.TabIndex = 13;
            this.ErrorLabel.Text = "Некоректні символи";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ErrorLabel.Visible = false;
            this.ErrorLabel.Click += new System.EventHandler(this.ErrorLabel_Click);
            // 
            // NameSurnameErrorLabel
            // 
            this.NameSurnameErrorLabel.AutoSize = true;
            this.NameSurnameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameSurnameErrorLabel.Location = new System.Drawing.Point(12, 70);
            this.NameSurnameErrorLabel.Name = "NameSurnameErrorLabel";
            this.NameSurnameErrorLabel.Size = new System.Drawing.Size(135, 15);
            this.NameSurnameErrorLabel.TabIndex = 15;
            this.NameSurnameErrorLabel.Text = "Пусте ім\'я чи прізвище";
            this.NameSurnameErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameSurnameErrorLabel.Visible = false;
            // 
            // DateOfBirthSelector
            // 
            this.DateOfBirthSelector.Location = new System.Drawing.Point(274, 109);
            this.DateOfBirthSelector.Name = "DateOfBirthSelector";
            this.DateOfBirthSelector.Size = new System.Drawing.Size(281, 23);
            this.DateOfBirthSelector.TabIndex = 16;
            this.DateOfBirthSelector.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PositionGroupBox
            // 
            this.PositionGroupBox.Controls.Add(this.ForwardRadioButton);
            this.PositionGroupBox.Controls.Add(this.MiddlefielderRadioButton);
            this.PositionGroupBox.Controls.Add(this.DefenderRadioButton);
            this.PositionGroupBox.Controls.Add(this.GoalkeeperRadioButton);
            this.PositionGroupBox.Location = new System.Drawing.Point(380, 138);
            this.PositionGroupBox.Name = "PositionGroupBox";
            this.PositionGroupBox.Size = new System.Drawing.Size(175, 162);
            this.PositionGroupBox.TabIndex = 17;
            this.PositionGroupBox.TabStop = false;
            this.PositionGroupBox.Text = "Позиція";
            // 
            // ForwardRadioButton
            // 
            this.ForwardRadioButton.AutoSize = true;
            this.ForwardRadioButton.Location = new System.Drawing.Point(9, 97);
            this.ForwardRadioButton.Name = "ForwardRadioButton";
            this.ForwardRadioButton.Size = new System.Drawing.Size(73, 19);
            this.ForwardRadioButton.TabIndex = 3;
            this.ForwardRadioButton.Text = "Форвард";
            this.ForwardRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddlefielderRadioButton
            // 
            this.MiddlefielderRadioButton.AutoSize = true;
            this.MiddlefielderRadioButton.Location = new System.Drawing.Point(9, 72);
            this.MiddlefielderRadioButton.Name = "MiddlefielderRadioButton";
            this.MiddlefielderRadioButton.Size = new System.Drawing.Size(93, 19);
            this.MiddlefielderRadioButton.TabIndex = 2;
            this.MiddlefielderRadioButton.Text = "Півзахисник";
            this.MiddlefielderRadioButton.UseVisualStyleBackColor = true;
            // 
            // DefenderRadioButton
            // 
            this.DefenderRadioButton.AutoSize = true;
            this.DefenderRadioButton.Location = new System.Drawing.Point(9, 47);
            this.DefenderRadioButton.Name = "DefenderRadioButton";
            this.DefenderRadioButton.Size = new System.Drawing.Size(77, 19);
            this.DefenderRadioButton.TabIndex = 1;
            this.DefenderRadioButton.Text = "Захисник";
            this.DefenderRadioButton.UseVisualStyleBackColor = true;
            // 
            // GoalkeeperRadioButton
            // 
            this.GoalkeeperRadioButton.AutoSize = true;
            this.GoalkeeperRadioButton.Location = new System.Drawing.Point(9, 22);
            this.GoalkeeperRadioButton.Name = "GoalkeeperRadioButton";
            this.GoalkeeperRadioButton.Size = new System.Drawing.Size(71, 19);
            this.GoalkeeperRadioButton.TabIndex = 0;
            this.GoalkeeperRadioButton.Text = "Воротар";
            this.GoalkeeperRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlayerEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.PositionGroupBox);
            this.Controls.Add(this.DateOfBirthSelector);
            this.Controls.Add(this.NameSurnameErrorLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.HealthGroupBox);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "PlayerEditing";
            this.Text = "Зміна інформації про гравця";
            this.Load += new System.EventHandler(this.PlayerEditing_Load);
            this.StatusGroupBox.ResumeLayout(false);
            this.StatusGroupBox.PerformLayout();
            this.HealthGroupBox.ResumeLayout(false);
            this.HealthGroupBox.PerformLayout();
            this.PositionGroupBox.ResumeLayout(false);
            this.PositionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private Label SurnameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label DateOfBirthLabel;
        private GroupBox StatusGroupBox;
        private GroupBox HealthGroupBox;
        private TextBox SalaryTextBox;
        private Label SalaryLabel;
        private Button SaveButton;
        private Label ErrorLabel;
        private RadioButton UnavailableRadioButton;
        private RadioButton AvailableRadioButton;
        private RadioButton TraumaRadioButton;
        private RadioButton MinorTraumaRadioButton;
        private RadioButton HealthyRadioButton;
        private Label NameSurnameErrorLabel;
        private DateTimePicker DateOfBirthSelector;
        private GroupBox PositionGroupBox;
        private RadioButton ForwardRadioButton;
        private RadioButton MiddlefielderRadioButton;
        private RadioButton DefenderRadioButton;
        private RadioButton GoalkeeperRadioButton;
    }
}