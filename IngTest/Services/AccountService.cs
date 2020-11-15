using IngTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Services
{
    public class AccountService // will return accounts from Json
    {
        //public static string absolutePathToAccountsJson = "C:/Users/George/source/repos/IngTest/IngTest/Resources/accountsJson.json";
        public static List<Account> GetAccounts(string path)
        {
            List<Account> itemsFromRelative = new List<Account>();
            try
            {

                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    itemsFromRelative = JsonConvert.DeserializeObject<List<Account>>(json);
                }
            }
            catch(Exception ex) { }

            return itemsFromRelative;
        }
    }
}
