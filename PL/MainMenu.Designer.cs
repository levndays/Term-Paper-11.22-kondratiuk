namespace PL
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListsMenu = new System.Windows.Forms.TabControl();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.PlayersGrid = new System.Windows.Forms.DataGridView();
            this.GamesTab = new System.Windows.Forms.TabPage();
            this.GamesGrid = new System.Windows.Forms.DataGridView();
            this.StadiumTab = new System.Windows.Forms.TabPage();
            this.StadiumsGrid = new System.Windows.Forms.DataGridView();
            this.TeamsTab = new System.Windows.Forms.TabPage();
            this.TeamsGrid = new System.Windows.Forms.DataGridView();
            this.SavingFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveFolderButton = new System.Windows.Forms.Button();
            this.SettingsTabel = new System.Windows.Forms.Label();
            this.ControlsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ReloadAndSaveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResetResult = new System.Windows.Forms.Button();
            this.DateSearchDateSelector = new System.Windows.Forms.DateTimePicker();
            this.DateSearch = new System.Windows.Forms.Label();
            this.ListsMenu.SuspendLayout();
            this.PlayersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).BeginInit();
            this.GamesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesGrid)).BeginInit();
            this.StadiumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StadiumsGrid)).BeginInit();
            this.TeamsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListsMenu
            // 
            this.ListsMenu.Controls.Add(this.PlayersTab);
            this.ListsMenu.Controls.Add(this.GamesTab);
            this.ListsMenu.Controls.Add(this.StadiumTab);
            this.ListsMenu.Controls.Add(this.TeamsTab);
            this.ListsMenu.HotTrack = true;
            this.ListsMenu.Location = new System.Drawing.Point(12, 12);
            this.ListsMenu.Multiline = true;
            this.ListsMenu.Name = "ListsMenu";
            this.ListsMenu.SelectedIndex = 0;
            this.ListsMenu.Size = new System.Drawing.Size(524, 507);
            this.ListsMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ListsMenu.TabIndex = 1;
            // 
            // PlayersTab
            // 
            this.PlayersTab.Controls.Add(this.PlayersGrid);
            this.PlayersTab.Location = new System.Drawing.Point(4, 24);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTab.Size = new System.Drawing.Size(516, 479);
            this.PlayersTab.TabIndex = 0;
            this.PlayersTab.Text = "Гравці";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // PlayersGrid
            // 
            this.PlayersGrid.AllowUserToAddRows = false;
            this.PlayersGrid.AllowUserToDeleteRows = false;
            this.PlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PlayersGrid.Location = new System.Drawing.Point(3, 3);
            this.PlayersGrid.Name = "PlayersGrid";
            this.PlayersGrid.ReadOnly = true;
            this.PlayersGrid.RowTemplate.Height = 25;
            this.PlayersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayersGrid.Size = new System.Drawing.Size(510, 473);
            this.PlayersGrid.TabIndex = 0;
            this.PlayersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayersGrid_CellContentClick);
            // 
            // GamesTab
            // 
            this.GamesTab.Controls.Add(this.GamesGrid);
            this.GamesTab.Location = new System.Drawing.Point(4, 24);
            this.GamesTab.Name = "GamesTab";
            this.GamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.GamesTab.Size = new System.Drawing.Size(516, 479);
            this.GamesTab.TabIndex = 1;
            this.GamesTab.Text = "Ігри";
            this.GamesTab.UseVisualStyleBackColor = true;
            this.GamesTab.Click += new System.EventHandler(this.GamesTab_MouseClick);
            // 
            // GamesGrid
            // 
            this.GamesGrid.AllowUserToAddRows = false;
            this.GamesGrid.AllowUserToDeleteRows = false;
            this.GamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesGrid.Location = new System.Drawing.Point(3, 3);
            this.GamesGrid.Name = "GamesGrid";
            this.GamesGrid.ReadOnly = true;
            this.GamesGrid.RowTemplate.Height = 25;
            this.GamesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GamesGrid.Size = new System.Drawing.Size(510, 473);
            this.GamesGrid.TabIndex = 0;
            // 
            // StadiumTab
            // 
            this.StadiumTab.Controls.Add(this.StadiumsGrid);
            this.StadiumTab.Location = new System.Drawing.Point(4, 24);
            this.StadiumTab.Name = "StadiumTab";
            this.StadiumTab.Padding = new System.Windows.Forms.Padding(3);
            this.StadiumTab.Size = new System.Drawing.Size(516, 479);
            this.StadiumTab.TabIndex = 2;
            this.StadiumTab.Text = "Стадіони";
            this.StadiumTab.UseVisualStyleBackColor = true;
            // 
            // StadiumsGrid
            // 
            this.StadiumsGrid.AllowUserToAddRows = false;
            this.StadiumsGrid.AllowUserToDeleteRows = false;
            this.StadiumsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StadiumsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StadiumsGrid.Location = new System.Drawing.Point(3, 3);
            this.StadiumsGrid.Name = "StadiumsGrid";
            this.StadiumsGrid.ReadOnly = true;
            this.StadiumsGrid.RowTemplate.Height = 25;
            this.StadiumsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StadiumsGrid.Size = new System.Drawing.Size(510, 473);
            this.StadiumsGrid.TabIndex = 0;
            // 
            // TeamsTab
            // 
            this.TeamsTab.Controls.Add(this.TeamsGrid);
            this.TeamsTab.Location = new System.Drawing.Point(4, 24);
            this.TeamsTab.Name = "TeamsTab";
            this.TeamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeamsTab.Size = new System.Drawing.Size(516, 479);
            this.TeamsTab.TabIndex = 3;
            this.TeamsTab.Text = "Команди";
            this.TeamsTab.UseVisualStyleBackColor = true;
            // 
            // TeamsGrid
            // 
            this.TeamsGrid.AllowUserToAddRows = false;
            this.TeamsGrid.AllowUserToDeleteRows = false;
            this.TeamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsGrid.Location = new System.Drawing.Point(3, 3);
            this.TeamsGrid.Name = "TeamsGrid";
            this.TeamsGrid.ReadOnly = true;
            this.TeamsGrid.RowTemplate.Height = 25;
            this.TeamsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeamsGrid.Size = new System.Drawing.Size(510, 473);
            this.TeamsGrid.TabIndex = 0;
            // 
            // SaveFolderButton
            // 
            this.SaveFolderButton.Location = new System.Drawing.Point(552, 64);
            this.SaveFolderButton.Name = "SaveFolderButton";
            this.SaveFolderButton.Size = new System.Drawing.Size(236, 36);
            this.SaveFolderButton.TabIndex = 2;
            this.SaveFolderButton.Text = "Змінити папку для роботи з файлами";
            this.SaveFolderButton.UseVisualStyleBackColor = true;
            this.SaveFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsTabel
            // 
            this.SettingsTabel.AutoSize = true;
            this.SettingsTabel.Location = new System.Drawing.Point(552, 36);
            this.SettingsTabel.Name = "SettingsTabel";
            this.SettingsTabel.Size = new System.Drawing.Size(89, 15);
            this.SettingsTabel.TabIndex = 3;
            this.SettingsTabel.Text = "Налаштування";
            // 
            // ControlsLabel
            // 
            this.ControlsLabel.AutoSize = true;
            this.ControlsLabel.Location = new System.Drawing.Point(552, 152);
            this.ControlsLabel.Name = "ControlsLabel";
            this.ControlsLabel.Size = new System.Drawing.Size(65, 15);
            this.ControlsLabel.TabIndex = 4;
            this.ControlsLabel.Text = "Керування";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(552, 183);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 29);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(675, 183);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(113, 29);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(552, 218);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(236, 29);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Змінити";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReloadAndSaveButton
            // 
            this.ReloadAndSaveButton.Location = new System.Drawing.Point(552, 483);
            this.ReloadAndSaveButton.Name = "ReloadAndSaveButton";
            this.ReloadAndSaveButton.Size = new System.Drawing.Size(236, 29);
            this.ReloadAndSaveButton.TabIndex = 9;
            this.ReloadAndSaveButton.Text = "Оновити і зберегти";
            this.ReloadAndSaveButton.UseVisualStyleBackColor = true;
            this.ReloadAndSaveButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(552, 253);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(236, 29);
            this.DisplayButton.TabIndex = 10;
            this.DisplayButton.Text = "Переглянути";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(552, 302);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(46, 15);
            this.SearchLabel.TabIndex = 11;
            this.SearchLabel.Text = "Пошук";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(552, 320);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(236, 23);
            this.SearchTextBox.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(552, 399);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(113, 29);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Шукати";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResetResult
            // 
            this.ResetResult.Location = new System.Drawing.Point(675, 399);
            this.ResetResult.Name = "ResetResult";
            this.ResetResult.Size = new System.Drawing.Size(113, 29);
            this.ResetResult.TabIndex = 14;
            this.ResetResult.Text = "Скинути";
            this.ResetResult.UseVisualStyleBackColor = true;
            this.ResetResult.Click += new System.EventHandler(this.button3_Click);
            // 
            // DateSearchDateSelector
            // 
            this.DateSearchDateSelector.Location = new System.Drawing.Point(552, 370);
            this.DateSearchDateSelector.Name = "DateSearchDateSelector";
            this.DateSearchDateSelector.Size = new System.Drawing.Size(236, 23);
            this.DateSearchDateSelector.TabIndex = 15;
            this.DateSearchDateSelector.Visible = false;
            this.DateSearchDateSelector.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DateSearch
            // 
            this.DateSearch.AutoSize = true;
            this.DateSearch.Location = new System.Drawing.Point(552, 352);
            this.DateSearch.Name = "DateSearch";
            this.DateSearch.Size = new System.Drawing.Size(97, 15);
            this.DateSearch.TabIndex = 16;
            this.DateSearch.Text = "Пошук за датою";
            this.DateSearch.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 531);
            this.Controls.Add(this.DateSearch);
            this.Controls.Add(this.DateSearchDateSelector);
            this.Controls.Add(this.ResetResult);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ReloadAndSaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ControlsLabel);
            this.Controls.Add(this.SettingsTabel);
            this.Controls.Add(this.SaveFolderButton);
            this.Controls.Add(this.ListsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "Курсова робота І Кондратюк А. І ПІ221Б";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ListsMenu.ResumeLayout(false);
            this.PlayersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).EndInit();
            this.GamesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamesGrid)).EndInit();
            this.StadiumTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StadiumsGrid)).EndInit();
            this.TeamsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl ListsMenu;
        private TabPage PlayersTab;
        private TabPage GamesTab;
        private TabPage StadiumTab;
        private FolderBrowserDialog SavingFolderDialog;
        private Button SaveFolderButton;
        private Label SettingsTabel;
        private Label ControlsLabel;
        private Button AddButton;
        private Button RemoveButton;
        private Button EditButton;
        private Button ReloadAndSaveButton;
        private TabPage TeamsTab;
        private DataGridView TeamsGrid;
        private DataGridView PlayersGrid;
        private DataGridView GamesGrid;
        private DataGridView StadiumsGrid;
        private Button DisplayButton;
        private Label SearchLabel;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button ResetResult;
        private DateTimePicker DateSearchDateSelector;
        private Label DateSearch;
    }
}