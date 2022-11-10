using DAL;
using System.Diagnostics;
using System.Xml.Linq;

namespace PL
{
    public partial class StadiumEditing : Form
    {
        Stadium Item;
        public StadiumEditing(Stadium StadiumToEdit)
        {
            InitializeComponent();
            Item = StadiumToEdit;
            NameTextBox.Text = Item.Name;
            SeatsTextBox.Text = Convert.ToString(Item.Seats);
            SeatPriceTextBox.Text = Convert.ToString(Item.SeatPrice);
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
                }
                catch
                {
                    throw new Exception("Некорректна кількість місць");
                }

                try
                {
                    SeatPrice = double.Parse(SeatPriceTextBox.Text);
                }
                catch
                {
                    throw new Exception("Некорректна ціна місця");
                }

                if (SeatPrice < 0)
                {
                    throw new Exception("Ціна на місце нижче нуля");
                }
                List<String> Games = Item.Games;

                BLL.StadiumLogic.ReplaceStadium(new(Name, Seats, Seats, Games), DAL.Lists.Stadiums.IndexOf(Item));
                Close();
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Некорректна кількість місць":
                        PlacesLabel.Text = ex.Message;
                        PlacesLabel.ForeColor = Color.Red;
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