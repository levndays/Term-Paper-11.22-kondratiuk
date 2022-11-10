using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Team
    {
        public Team(string name, Player goalkeeper, List<Player> defenders, List<Player> middlefielders, List<Player> forwards)
        {
            Name = name;
            Goalkeeper = goalkeeper;
            Defenders = defenders;
            Middlefielders = middlefielders;
            Forwards = forwards;
        }

        public string Name { get; set; }
        public Player Goalkeeper { get; set; }
        public List<Player> Defenders { get; set; }
        public List<Player> Middlefielders { get; set; }

        public List<Player> Forwards { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }


        public Team Copy()
        {
            return (Team)this.MemberwiseClone();
        }

        public string Display()
        {
            string players = Goalkeeper.ToString();
            for (int i = 0; i < Defenders.Count; i++)
            {
                players += "\n" + Defenders[i].ToString();
            }
            for (int i = 0; i < Middlefielders.Count; i++)
            {
                players += "\n" + Middlefielders[i].ToString();
            }
            for (int i = 0; i < Forwards.Count; i++)
            {
                players += "\n" + Forwards[i].ToString();
            }

            return $"Команда \"{Name}\"\nГравці:\n{players}";
        }
    }
}
