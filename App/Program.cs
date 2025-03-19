using ATMApp.Domain.Entities;
using System.Collections.Generic;

namespace ATMApp
{
    class Program
    { 
         
        private List<UserAccount> userAccounts;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccounts = new List<UserAccount>
            {
                new UserAccount { Id = 1, FullName = "Priyamraj", AccountNumber = 123456, CardNumber = 321321, CardPin = 123123, AccountBalance = 50000.00m, IsLocked = false },
                new UserAccount { Id = 2, FullName = "Amaka Hope", AccountNumber = 456789, CardNumber = 654654, CardPin = 456456, AccountBalance = 40000.00m, IsLocked = false },
                new UserAccount { Id = 3, FullName = "Femi Sunday", AccountNumber = 123555, CardNumber = 987987, CardPin = 789789, AccountBalance = 2000.00m, IsLocked = true }
            };
        }
    }
}
