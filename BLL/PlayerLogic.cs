using DAL;

namespace BLL
{
    public static class PlayerLogic
    {
        public static bool AddPlayer(DAL.Player obj)
        {
            try
            {
                DAL.Lists.Players.Add(obj);
                return true;
            }
            catch
            {
                throw new Exception("Player Addition Exception");
            }
        }
        public static bool ReplacePlayer(DAL.Player obj, int position)
        {
            try
            {
                DAL.Lists.Players.RemoveAt(position);
                DAL.Lists.Players.Insert(position, obj);
                return true;
            }
            catch
            {
                throw new Exception("Player Replacement Exception");
            }
        }
        public static List<Player> FindPlayer(string key)
        {
            var NewList = DAL.Lists.Players.FindAll(n => n.FirstName == key || n.LastName == key);
            return NewList;
        }
    }
}