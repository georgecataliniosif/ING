using IngTest.Models;
using IngTest.Responses;
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
    public class AccountsController : ControllerBase
    {
        public static string relativePathToAccountsJson = "./Resources/accountsJson.json";

        [HttpGet]
        public AccountsResponse Get()
        {
            AccountsResponse response = new AccountsResponse();

            response.accounts = AccountService.GetAccounts(relativePathToAccountsJson);

            return response;
        }
    }
}
