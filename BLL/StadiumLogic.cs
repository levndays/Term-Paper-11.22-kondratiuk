using DAL;

namespace BLL
{
    public static class StadiumLogic
    {
        public static bool AddStadium(DAL.Stadium obj)
        {
            try
            {
                DAL.Lists.Stadiums.Add(obj);
                return true;
            }
            catch
            {
                throw new Exception("Stadium Addition Exception");
            }
        }
        public static bool ReplaceStadium(DAL.Stadium obj, int position)
        {
            try
            {
                DAL.Lists.Stadiums.RemoveAt(position);
                DAL.Lists.Stadiums.Insert(position, obj);
                return true;
            }
            catch
            {
                throw new Exception("Stadium Replacement Exception");
            }
        }
        public static List<Stadium> FindStadium(string key)
        {
            var NewList = DAL.Lists.Stadiums.FindAll(n => n.Name == key || n.Name == key);
            return NewList;
        }
    }
}
