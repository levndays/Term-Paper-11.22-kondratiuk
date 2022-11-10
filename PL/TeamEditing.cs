using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PL
{
    public partial class TeamEditing : Form
    {
        List<Player> TempList = new List<Player>();
        Team TeamList;

        private void InitializeTable()
        {
            PlayersList.Items.Clear();
            foreach (var player in TempList)
            {
                PlayersList.Items.Add(player);
            }
            GoalkeeperCountLabel.Text = $"{GoalkeepersList.Items.Count}/1";
            ForwardsCountLabel.Text = $"{ForwardsList.Items.Count}/3";
            MiddlefieldersCountLabel.Text = $"{MiddlefieldersList.Items.Count}/6";
            DefendersCountLabel.Text = $"{DefendersList.Items.Count}/5";
            PlayersInTeamCountLabel.Text = $"{GoalkeepersList.Items.Count + DefendersList.Items.Count + MiddlefieldersList.Items.Count + ForwardsList.Items.Count}/11";
        }
        public TeamEditing(Team Item)
        {
            TeamList = Item;
            InitializeComponent();
            InitializeTable();
            GoalkeepersList.Items.Add(Item.Goalkeeper);

            foreach (var player in Item.Defenders)
            {
                DefendersList.Items.Add(player);
            }
            foreach (var player in Item.Middlefielders)
            {
                MiddlefieldersList.Items.Add(player);
            }
            foreach (var player in Item.Forwards)
            {
                ForwardsList.Items.Add(player);
            }
            TeamNameTextBox.Text = Item.Name;

            for (int i = 0; i < DAL.Lists.Players.Count; i++)
            {
                TempList.Add(DAL.Lists.Players[i].Copy());
            }
        }

        private void PlayersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GoalkeepersList.Items.Count + DefendersList.Items.Count + MiddlefieldersList.Items.Count + ForwardsList.Items.Count == 11)
            {
                PlayersInTeamCountLabel.Text = "MAX";
                PlayersInTeamCountLabel.ForeColor = Color.Red;
                PlayersInTeamCountLabel.Visible = true;
            }
            else
            {
                Player obj = (Player)PlayersList.SelectedItem;
                switch (obj.Position)
                {
                    case ("Воротар"):
                        if (GoalkeepersList.Items.Count == 0) // тільки один воротар в команді
                        {
                            GoalkeepersList.Items.Add(obj);
                            TempList.Remove(obj);
                        }
                        else
                        {
                            GoalkeeperErrorLabel.Visible = true;
                        }
                        break;
                    case ("Захисник"):
                        if (DefendersList.Items.Count <= 5) // максимум 5 захисників
                        {
                            DefendersList.Items.Add(obj);
                            TempList.Remove(obj);
                        }
                        else
                        {
                            DefendersErrorLabel.Visible = true;
                        }
                        break;
                    case ("Форвард"):
                        if (ForwardsList.Items.Count <= 3) // максимум 3 форварда
                        {
                            ForwardsList.Items.Add(obj);
                            TempList.Remove(obj);
                        }
                        else
                        {
                            MiddlefieldersErrorLabel.Visible = true;
                        }
                        break;
                    case ("Півзахисник"):
                        if (MiddlefieldersList.Items.Count <= 6)
                        {
                            MiddlefieldersList.Items.Add(obj);
                            TempList.Remove(obj);
                        }
                        else
                        {
                            ForwardsErrorLabel.Visible = true;
                        }
                        break;
                }
                InitializeTable();
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TempList.Add((Player)GoalkeepersList.Items[GoalkeepersList.Items.Count - 1]);
            GoalkeepersList.Items.RemoveAt(GoalkeepersList.Items.Count - 1);
            InitializeTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempList.Add((Player)DefendersList.Items[DefendersList.SelectedIndex]);
            DefendersList.Items.RemoveAt(DefendersList.SelectedIndex);
            InitializeTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TempList.Add((Player)MiddlefieldersList.Items[MiddlefieldersList.SelectedIndex]);
            MiddlefieldersList.Items.RemoveAt(MiddlefieldersList.SelectedIndex);
            InitializeTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TempList.Add((Player)ForwardsList.Items[ForwardsList.SelectedIndex]);
            ForwardsList.Items.RemoveAt(ForwardsList.SelectedIndex);
            InitializeTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TeamNameTextBox.Text;
                Player goalkeeper;
                List<Player> Defenders = new List<Player>();
                List<Player> Middlefielders = new List<Player>();
                List<Player> Forwards = new List<Player>();

                if (name == "")
                {
                    throw new Exception("empty name");
                }
                try
                {
                    goalkeeper = (Player)GoalkeepersList.Items[0];
                }
                catch
                {
                    throw new Exception("no goalkeeper");
                }

                for (int i = 0; i < DefendersList.Items.Count; i++)
                {
                    Defenders.Add((Player)DefendersList.Items[i]);
                }

                for (int i = 0; i < MiddlefieldersList.Items.Count; i++)
                {
                    Defenders.Add((Player)MiddlefieldersList.Items[i]);
                }

                for (int i = 0; i < ForwardsList.Items.Count; i++)
                {
                    Forwards.Add((Player)ForwardsList.Items[i]);
                }

                if (Defenders.Count + Middlefielders.Count + Forwards.Count < 10)
                {
                    throw new Exception("not enough players");
                }

                BLL.TeamLogic.ReplaceTeam(new(name, goalkeeper, Defenders, Middlefielders, Forwards), DAL.Lists.Teams.IndexOf(TeamList));
                Close();
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "empty name":
                        TeamNameLabel.Text = "Пуста назва команди!";
                        TeamNameLabel.ForeColor = Color.Red;
                        break;
                    case "no goalkeeper":
                        // message box
                        break;
                    case "not enough players":
                        // message box
                        break;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
