using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class StadiumAddition : Form
    {
        public StadiumAddition()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTextBox.Text;
                ushort Seats;
                double SeatPrice;
                try
                {
                     Seats = ushort.Parse(SeatsTextBox.Text);
                } catch
                {
                    throw new Exception("Некорректна кількість місць");
                }
                
                try
                {
                    SeatPrice = double.Parse(this.SeatPrice.Text);
                }
                catch
                {
                    throw new Exception("Некорректна ціна місця");
                }

                if (SeatPrice < 0)
                {
                    throw new Exception("Ціна на місце нижче нуля");
                }
                List<String> Games = new List<String>();

                BLL.StadiumLogic.AddStadium(new(Name, Seats, SeatPrice, Games));
                Close();
            } catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Некорректна кількість місць":
                        SeatsLabel.Text = ex.Message;
                        SeatsLabel.ForeColor = Color.Red;
                        break;
                    case "Некорректна ціна місця":
                        SeatPriceLabel.Text = ex.Message;
                        SeatPriceLabel.ForeColor = Color.Red;
                        break;
                    case "Ціна на місце нижче нуля":
                        SeatPriceLabel.Text = ex.Message;
                        SeatPriceLabel.ForeColor = Color.Red;
                        break;
                }
            }
        }
    }
}
