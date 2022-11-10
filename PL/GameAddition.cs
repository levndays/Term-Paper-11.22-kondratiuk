using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PL
{
    public partial class GameAddition : Form
    {
        List<Team> Teams = DAL.Lists.Teams;
        ushort HomeTeamScore;
        ushort GuestTeamScore;
        string[] statuses = new string[4] { "Перемога домашньої команди", "Перемога гостьової команди", "Нічия", "Не зіграно" };
        public GameAddition()
        {
            InitializeComponent();
            InitializeFields();
        }
        void InitializeFields()
        {
            foreach (var team in Teams)
            {
                HomeTeamComboBox.Items.Add(team);
            }

            foreach (var team in Teams)
            {
                GuestTeamComboBox.Items.Add(team);
            }

            StadiumComboBox.DataSource = DAL.Lists.Stadiums;
            HomeTeamScore = 0;
            GuestTeamScore = 0;
            
            RefreshScore();
        }
        void RefreshScore()
        {
            HomeTeamScoreLabel.Text = Convert.ToString(HomeTeamScore);
            GuestTeamScoreLabel.Text = Convert.ToString(GuestTeamScore);
            if (HomeTeamScore == 0 && GuestTeamScore == 0)
            {
                StatusComboBox.Items.Clear();
                StatusComboBox.Items.Add("Нічия");
                StatusComboBox.Items.Add("Не зіграно");
                StatusComboBox.SelectedIndex = 0;
                StatusComboBox.Enabled = true;
            }
            if (HomeTeamScore >= 1)
            {
                HomeTeamScoreDecreaseButton.Visible = true;
            } else
            {
                HomeTeamScoreDecreaseButton.Visible = false;
            }
            if (GuestTeamScore >= 1)
            {
                GuestTeamScoreDecreaseButton.Visible = true;
            }
            else
            {
                GuestTeamScoreDecreaseButton.Visible = false;
            }
            
            if (HomeTeamScore >= 1 || GuestTeamScore >= 1)
            {
                StatusComboBox.Enabled = false;
                if (HomeTeamScore > GuestTeamScore)
                {
                    StatusComboBox.Items.Clear();
                    StatusComboBox.Items.AddRange(statuses);
                    StatusComboBox.SelectedIndex = 0;
                }
                if (HomeTeamScore < GuestTeamScore)
                {
                    StatusComboBox.Items.Clear();
                    StatusComboBox.Items.AddRange(statuses);
                    StatusComboBox.SelectedIndex = 1;
                }
            }
            if (HomeTeamScore > 0 && GuestTeamScore > 0 && HomeTeamScore == GuestTeamScore)
            {
                StatusComboBox.Items.Clear();
                StatusComboBox.Items.Add("Нічия");
                StatusComboBox.SelectedIndex = 0;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            HomeTeamScore++;
            RefreshScore();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeTeamScore--;
            RefreshScore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuestTeamScore--;
            RefreshScore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestTeamScore++;
            RefreshScore();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                uint Spectators = uint.Parse(SpectatorsTextBox.Text);
                if (Spectators > DAL.Lists.Stadiums[StadiumComboBox.SelectedIndex].Seats)
                {
                    throw new Exception("Глядачів на грі більше ніж місць на стадіоні");
                }

                BLL.GameLogic.AddGame(new((Team)HomeTeamComboBox.SelectedItem, (Team)HomeTeamComboBox.SelectedItem, GameDateSelector.Value, (Stadium)StadiumComboBox.SelectedItem, Spectators, HomeTeamScore, GuestTeamScore, StatusComboBox.SelectedItem.ToString()), DAL.Lists.Stadiums[StadiumComboBox.SelectedIndex]);
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Помилка (некоректні дані)\n" + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teams.Remove((Team)HomeTeamComboBox.SelectedItem);
            GuestTeamComboBox.DataSource = Teams;
        }
    }
}
