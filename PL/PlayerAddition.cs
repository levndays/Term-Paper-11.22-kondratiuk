using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using BLL;

namespace PL
{
    public partial class PlayerAddition : Form
    {
        public PlayerAddition()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs ex)
        {
            try
            {
                double salary;
                string Status = StatusGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
                string HealthCondition = HealthGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
                string Name;
                string Surname;
                string Position = PositionGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
                DateTime DateOfBirth = DateOfBirthSelector.Value;

                if (Regex.IsMatch(SalaryTextBox.Text, @"^\d+$"))
                {
                    salary = Convert.ToDouble(SalaryTextBox.Text);
                }
                else
                {
                    throw new Exception("no digits in salary");
                }

                if (FirstNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0)
                {
                    throw new Exception("empty name or surname");
                }
                else
                {
                    Name = FirstNameTextBox.Text;
                    Surname = LastNameTextBox.Text;
                }

                BLL.PlayerLogic.AddPlayer(new(Name, Surname, DateOfBirth, Status, HealthCondition, salary, Position));
                Close();

            }
            catch (Exception e)
            {
                if (e.Message == "no digits in salary")
                {
                    ErrorLabel.Visible = true;
                }
                if (e.Message == "empty name or surname")
                {
                    NameSurnameErrorLabel.Visible = true;
                }
            }

            
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TraumaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TraumaRadioButton.Checked == true)
            {
                AvailableRadioButton.Checked = false;
                AvailableRadioButton.Enabled = false;
                UnavailableRadioButton.Checked = true;
            }
        }

        private void MinorTraumaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MinorTraumaRadioButton.Checked == true)
            {
                AvailableRadioButton.Enabled = true;
            }
        }

        private void HealthyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HealthyRadioButton.Checked == true)
            {
                AvailableRadioButton.Enabled = true;
            }
        }
    }

}

