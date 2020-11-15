using IngTest.Models;
using IngTest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        public static string relativePathToAccountsJson = "./Resources/accountsJson.json";

        [Route("report")]
        [HttpGet]
        public IEnumerable<Report> Get()
        {
            List<Report> response = new List<Report>();
            List<Transaction> transactions = TransactionsService.GetTransactions();
            List<CategoryDescription> categoryDescriptions = DictionariesService.GetCategoryDescriptions();
            List<Account> accounts = AccountService.GetAccounts(relativePathToAccountsJson);

            foreach (Transaction transaction in transactions)
            {
                CategoryDescription description = categoryDescriptions.FirstOrDefault(p => p.ID == transaction.categoryId);
                Account relatedAccount = accounts.FirstOrDefault(a => a.iban == transaction.iban);

                response.Add(new Report()
                {
                    categoryName = description != null ? description.Description : "UnknownCategory",
                    currency = relatedAccount != null ? relatedAccount.currency : "Unknown Currency",
                    totalAmmount = transaction.amount
                });
            }

            return response;
        }
    }
}
