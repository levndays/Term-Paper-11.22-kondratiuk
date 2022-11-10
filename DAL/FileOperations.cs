using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class Settings
    {
        public static string SavingFolder { get; set; } = System.IO.File.ReadAllText(@"SavingCatalog.txt");
    }

    public class FileOperations
    {
        
        public static void JSONWrite<T>(string path, T obj)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<T>(fs, obj, options);
            }
        }

        public static T JSONRead<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T obj = JsonSerializer.Deserialize<T>(fs);
                return obj;
            }
        }
    }
}
