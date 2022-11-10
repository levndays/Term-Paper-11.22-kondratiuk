using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class Lists
    {

        public static List<Player> Players;
        public static List<Game> Games;
        public static List<Stadium> Stadiums;
        public static List<Team> Teams; 

        public static void InitializeObjects()
        {
            try
            {
                Players = FileOperations.JSONRead<List<Player>>(Settings.SavingFolder + "\\players.json");
            }
            catch
            {
                Players = new List<Player>();
            }

            try
            {
                Games = FileOperations.JSONRead<List<Game>>(Settings.SavingFolder + "\\games.json");
            }
            catch
            {
                Games = new List<Game>();
            }

            try
            {
                Stadiums = FileOperations.JSONRead<List<Stadium>>(Settings.SavingFolder + "\\stadiums.json");
            }
            catch
            {
                Stadiums = new List<Stadium>();
            }

            try
            {
                Teams = FileOperations.JSONRead<List<Team>>(Settings.SavingFolder + "\\teams.json");
            }
            catch
            {
                Teams = new List<Team>();
            }

        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public static List<T> ToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}
