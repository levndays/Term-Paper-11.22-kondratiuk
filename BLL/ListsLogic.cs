using DAL;


namespace BLL
{
    public class ListsLogic
    {
        public static bool SaveLists()
        {
            try
            {
                System.IO.File.WriteAllText(DAL.Settings.SavingFolder + "\\players.json", string.Empty);
                System.IO.File.WriteAllText(DAL.Settings.SavingFolder + "\\games.json", string.Empty);
                System.IO.File.WriteAllText(DAL.Settings.SavingFolder + "\\stadiums.json", string.Empty);
                System.IO.File.WriteAllText(DAL.Settings.SavingFolder + "\\teams.json", string.Empty);
            }
            catch
            {
                throw new Exception("Error with file clearing");
            }

            try
            {
                DAL.FileOperations.JSONWrite<List<Player>>(DAL.Settings.SavingFolder + "\\players.json", DAL.Lists.Players);
                DAL.FileOperations.JSONWrite<List<Game>>(DAL.Settings.SavingFolder + "\\games.json", DAL.Lists.Games);
                DAL.FileOperations.JSONWrite<List<Stadium>>(DAL.Settings.SavingFolder + "\\stadiums.json", DAL.Lists.Stadiums);
                DAL.FileOperations.JSONWrite<List<Team>>(DAL.Settings.SavingFolder + "\\teams.json", DAL.Lists.Teams);
                return true;
            }
            catch
            {
                throw new Exception("Saving error");
            }

        }
        public static bool Remove(string key, int index)
        {
            switch (key.ToLower())
            {
                case "player":
                    try
                    {
                        DAL.Lists.Players.RemoveAt(index);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    break;
                case "game":
                    try
                    {
                        DAL.Lists.Games.RemoveAt(index);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    break;
                case "team":
                    try
                    {
                        DAL.Lists.Teams.RemoveAt(index);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    break;
                case "stadium":
                    try
                    {
                        DAL.Lists.Stadiums.RemoveAt(index);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
                    break;
            }
        }

        public static bool SaveSavingCatalog(string path)
        {
            try
            {
                File.WriteAllText("SavingCatalog.txt", path);
                DAL.Settings.SavingFolder = File.ReadAllText("SavingCatalog.txt");
                return true;
            }
            catch
            {
                throw new Exception("Saving Catalog wasn't saved");
            }
        }
    }
}
