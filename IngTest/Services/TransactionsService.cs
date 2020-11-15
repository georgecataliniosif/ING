using IngTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Services
{
    public class TransactionsService //will return transactions from Json
    {
        public static string relativePathToTransactionsJson = "./Resources/transactionsJson.json";
        public static List<Transaction> GetTransactions()
        {
            List<Transaction> items = new List<Transaction>();
        
            try
            {
                using (StreamReader r = new StreamReader(relativePathToTransactionsJson))
                {
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<Transaction>>(json);
                }
            }
            catch { };

            
            return items;

        }


    }
}
