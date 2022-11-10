using DAL;

namespace BLL
{
    public static class PlayerLogic
    {
        public static bool AddPlayer(DAL.Player obj)
        {
            DAL.Lists.Players.Add(obj);
            return true;
        }
        public static bool ReplacePlayer(DAL.Player obj, int position)
        {
            DAL.Lists.Players.RemoveAt(position);
            DAL.Lists.Players.Insert(position, obj);
            return true;
        }
        public static List<Player> FindPlayer(string key)
        {
            var NewList = DAL.Lists.Players.FindAll(n => n.FirstName == key || n.LastName == key);
            return NewList;
        }
    }
}