using IngTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Services
{
    public class DictionariesService
    {
        public static string relativePathToAccountsJson = "./Resources/categoriesListJson.json";
        public static List<CategoryDescription> GetCategoryDescriptions()
        {
            List<CategoryDescription> items = new List<CategoryDescription>();

            using (StreamReader r = new StreamReader(relativePathToAccountsJson))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<CategoryDescription>>(json);
            }

            return items;

        }
    }
}
