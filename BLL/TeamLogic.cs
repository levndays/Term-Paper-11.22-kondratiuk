using DAL;

namespace BLL
{
    public class TeamLogic
    {
        public static bool AddTeam(DAL.Team obj)
        {
            DAL.Lists.Teams.Add(obj);
            return true;
        }
        public static bool ReplaceTeam(DAL.Team obj, int position)
        {
            DAL.Lists.Teams.RemoveAt(position);
            DAL.Lists.Teams.Insert(position, obj);
            return true;
        }
    }
}
