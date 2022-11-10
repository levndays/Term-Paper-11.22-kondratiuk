using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class Game : ISerializable
    {
        public Game(Team homeTeam, Team guestTeam, DateTime date, Stadium stadium, uint spectators, ushort hometeamscore, ushort guestteamscore, string status)
        {
            HomeTeam = homeTeam;
            GuestTeam = guestTeam;
            Date = date;
            Stadium = stadium;
            Spectators = spectators;
            HomeTeamScore = hometeamscore;
            GuestTeamScore = guestteamscore;
            Status = status;
        }

        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public DateTime Date { get; set; }
        public Stadium Stadium { get; set; }
        public uint Spectators { get; set; }
        public ushort HomeTeamScore { get; set; } = 0;
        public ushort GuestTeamScore { get; set; } = 0;
        public string Status { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Home Team", HomeTeam);
            info.AddValue("Guest Team", GuestTeam);
            info.AddValue("Date", Date);
            info.AddValue("Stadium", Stadium);
            info.AddValue("Spectators", Spectators);
            info.AddValue("Status", Status);
            info.AddValue("Home Team Score", HomeTeamScore);
            info.AddValue("Guest Team Score", GuestTeamScore);

        }

        public override string ToString()
        {
            return $"{HomeTeam} проти {GuestTeam} ({HomeTeamScore}:{GuestTeamScore}) | {Date}";
        }

        public Game Copy()
        {
            return (Game)this.MemberwiseClone();
        }

        public string Display()
        {
            return $"Гра {HomeTeam} з {GuestTeam} ({HomeTeamScore} : {GuestTeamScore} - {Status});\nДата проведення: {Date};\nСтадіон - {Stadium} ({Spectators} глядачів)";
        }

    }
}
