using DAL;

namespace BLL
{
    public static class StadiumLogic
    {
        public static bool AddStadium(DAL.Stadium obj)
        {
            DAL.Lists.Stadiums.Add(obj);
            return true;
        }
        public static bool ReplaceStadium(DAL.Stadium obj, int position)
        {
            DAL.Lists.Stadiums.RemoveAt(position);
            DAL.Lists.Stadiums.Insert(position, obj);
            return true;
        }
        public static List<Stadium> FindStadium(string key)
        {
            var NewList = DAL.Lists.Stadiums.FindAll(n => n.Name == key || n.Name == key);
            return NewList;
        }
    }
}
