using DAL;

namespace BLL
{
    public class TeamLogic
    {
        public static bool AddTeam(DAL.Team obj)
        {
            try
            {
                DAL.Lists.Teams.Add(obj);
                return true;
            }
            catch
            {
                throw new Exception("Team Addition Exception");
            }
        }
        public static bool ReplaceTeam(DAL.Team obj, int position)
        {
            try
            {
                DAL.Lists.Teams.RemoveAt(position);
                DAL.Lists.Teams.Insert(position, obj);
                return true;
            }
            catch
            {
                throw new Exception("Team Replacement Exception");
            }
        }
    }
}
