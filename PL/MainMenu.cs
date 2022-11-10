using DAL;
using BLL;
using System.Data;

namespace PL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            DAL.Lists.InitializeObjects();
            InitializeTables();
        }

        public void InitializeTables()
        {
            PlayersGrid.DataSource = DAL.Lists.ToDataTable(DAL.Lists.Players);
            GamesGrid.DataSource = DAL.Lists.ToDataTable(DAL.Lists.Games);
            StadiumsGrid.DataSource = DAL.Lists.ToDataTable(DAL.Lists.Stadiums);
            TeamsGrid.DataSource = DAL.Lists.ToDataTable(DAL.Lists.Teams);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavingFolderDialog.ShowDialog();
            BLL.ListsLogic.SaveSavingCatalog(SavingFolderDialog.SelectedPath);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                PlayerAddition Addition = new();
                Addition.Show();
            }

            if (ListsMenu.SelectedTab == TeamsTab)
            {
                TeamAddition AddTeam = new();
                AddTeam.Show();
            }

            if (ListsMenu.SelectedTab == GamesTab)
            {
                GameAddition AddGame = new();
                AddGame.Show();
            }

            if (ListsMenu.SelectedTab == StadiumTab)
            {
                StadiumAddition AddStadion = new();
                AddStadion.Show();
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                BLL.ListsLogic.Remove("player", PlayersGrid.SelectedRows[0].Index);
            }

            if (ListsMenu.SelectedTab == TeamsTab)
            {
                BLL.ListsLogic.Remove("team", TeamsGrid.SelectedRows[0].Index);
            }

            if (ListsMenu.SelectedTab == GamesTab)
            {
                BLL.ListsLogic.Remove("game", GamesGrid.SelectedRows[0].Index);
            }

            if (ListsMenu.SelectedTab == StadiumTab)
            {
                BLL.ListsLogic.Remove("stadium", StadiumsGrid.SelectedRows[0].Index);
            }

            InitializeTables();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                Player EditedPlayer = DAL.Lists.Players[PlayersGrid.SelectedRows[0].Index];
                PlayerEditing Editing = new(EditedPlayer);
                Editing.Show();
            }

            if (ListsMenu.SelectedTab == GamesTab)
            {
                Game Item = DAL.Lists.Games[GamesGrid.SelectedRows[0].Index];
                GameEditing EditingGame = new(Item);
                EditingGame.Show();
            }

            if (ListsMenu.SelectedTab == TeamsTab)
            {
                Team EditingTeam = DAL.Lists.Teams[TeamsGrid.SelectedRows[0].Index];
                TeamEditing EditTeam = new(EditingTeam);
                EditTeam.Show();
            }

            if (ListsMenu.SelectedTab == StadiumTab)
            {
                Stadium Item = DAL.Lists.Stadiums[StadiumsGrid.SelectedRows[0].Index];
                StadiumEditing stadiumEditing = new StadiumEditing(Item); 
                stadiumEditing.Show();
            }

        }


        private void ReloadButton_Click(object sender, EventArgs e)
        {
            BLL.ListsLogic.SaveLists();
            InitializeTables();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                Player obj = DAL.Lists.Players[PlayersGrid.SelectedRows[0].Index];
                MessageBox.Show(obj.Display());
            }
            if (ListsMenu.SelectedTab == GamesTab)
            {
                Game obj = DAL.Lists.Games[GamesGrid.SelectedRows[0].Index];
                MessageBox.Show(obj.Display());
            }
            if (ListsMenu.SelectedTab == StadiumTab)
            {
                Stadium obj = DAL.Lists.Stadiums[StadiumsGrid.SelectedRows[0].Index];
                MessageBox.Show(obj.Display());
            }
            if (ListsMenu.SelectedTab == TeamsTab)
            {
                Team obj = DAL.Lists.Teams[TeamsGrid.SelectedRows[0].Index];
                MessageBox.Show(obj.Display());
            }
        }

        private void PlayersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                PlayersGrid.DataSource = BLL.PlayerLogic.FindPlayer(SearchTextBox.Text);
            }

            if (ListsMenu.SelectedTab == GamesTab)
            {
                GamesGrid.DataSource = BLL.GameLogic.FindGame(SearchTextBox.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == PlayersTab)
            {
                PlayersGrid.DataSource = DAL.Lists.Players;
            }
            if (ListsMenu.SelectedTab == StadiumTab)
            {
                StadiumsGrid.DataSource = DAL.Lists.Stadiums;
            }
            if (ListsMenu.SelectedTab == GamesTab)
            {
                GamesGrid.DataSource = DAL.Lists.Games;
            }
        }

        private void GamesTab_MouseClick(object sender, EventArgs e)
        {
            if (ListsMenu.SelectedTab == GamesTab)
            {
                SearchLabel.Text = "Пошук за командами";
                DateSearch.Visible = true;
                DateSearchDateSelector.Visible = true;
            } else
            {
                SearchLabel.Text = "Пошук";
                DateSearch.Visible = false;
                DateSearchDateSelector.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GamesGrid.DataSource = BLL.GameLogic.FindGameByDate(DateSearchDateSelector.Value);
        }
    }
}