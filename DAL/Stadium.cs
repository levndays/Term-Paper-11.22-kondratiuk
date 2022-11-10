using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class Stadium : ISerializable
    {
        public Stadium(string name, uint seats, double seatPrice, List<String> games)
        {
            this.Name = name;
            Seats = seats;
            SeatPrice = seatPrice;
            Games = games;
        }
        public string Name { get; set; }
        public uint Seats { get; set; }
        public double SeatPrice { get; set; }

        public List<String> Games { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Seats", Seats);
            info.AddValue("Seat Price", SeatPrice);
            info.AddValue("Games", Games);
        }
        public string Display()
        {
            string gamestring = "";
            for (int i = 0; i < Games.Count; i++)
            {
                gamestring += (Games[i] + "\n");
            }
            return $"Стадіон '{Name}'\n{Seats} місць; (${SeatPrice} за місце);\nІгри на стадіоні: {gamestring}";
        }
        public override string ToString()
        {
            return $"{Name}"; 
        }
    }
}
