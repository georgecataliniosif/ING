using IngTest.Models;
using IngTest.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace IngTestTest
{
    public class AccountServiceTest
    {
        public static string relativePathToTestAccountsJson = "./Resources/testAccountsJson.json";

        [Fact]
        public void GetAccounts_Should_Return_Account_Response_Object_With_One_Element()
        {
            //Arrange
            List<Account> expected = new List<Account>();
            expected.Add(new Account()
            {   currency = "EUR",
                iban = "NL69INGB0123456789",
                name = "Hr A van Dijk , Mw B Mol-van Dijk",
                product = "Betaalrekening",
                resourceId = "450ffbb8-9f11-4ec6-a1e1-df48aefc82ef"
            }) ;

            //ACT 
            List<Account> actual = AccountService.GetAccounts(relativePathToTestAccountsJson);

            //Assert
            Assert.Equal(expected[0].currency, actual[0].currency);
            Assert.Equal(expected[0].iban, actual[0].iban);
            Assert.Equal(expected[0].name, actual[0].name);
            Assert.Equal(expected[0].product, actual[0].product);
            Assert.Equal(expected[0].resourceId, actual[0].resourceId);
        }

        [Fact]
        public void GetAccounts_Should_Return_Empty_List()
        {
            //Arrange
            int expected = 0;

            //Act
            List<Account> result = AccountService.GetAccounts("badPath");
            int actual = result.Count;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
