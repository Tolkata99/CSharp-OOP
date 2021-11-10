using System;
using System.Collections.Generic;
using System.Text;

namespace Stealer
{
    public class Hacker
    {
        public string username = "securityGod82";

        private string password = "mySuperSecretpassw0rd";

        public string Password 
        {
            get => this.password;

            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccounBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {

        }


    }
}
