using DAL;

namespace BLL
{
    public static class GameLogic
    {
        public static bool AddGame(DAL.Game obj, DAL.Stadium stadium)
        {
            stadium.Games.Add(obj.ToString());
            DAL.Lists.Games.Add(obj);
            return true;
        }
        public static bool ReplaceGame(DAL.Game obj, DAL.Stadium stadium, int position)
        {
            DAL.Lists.Games.RemoveAt(position);
            stadium.Games.Add(obj.ToString());
            DAL.Lists.Games.Insert(position, obj);
            return true;
        }

        public static List<Game> FindGame(string key)
        {
            var NewList = DAL.Lists.Games.FindAll(n => n.HomeTeam.Name == key || n.GuestTeam.Name == key);
            return NewList;
        }
        public static List<Game> FindGameByDate(DateTime key)
        {
            var NewList = DAL.Lists.Games.FindAll(n => n.Date == key);
            return NewList;
        }
    }
}
