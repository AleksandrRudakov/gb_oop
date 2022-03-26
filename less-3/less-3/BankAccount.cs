using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_3
{
    enum AccountType
    {
        CurrentAccount,
        SavingsAccount,
        PaymentAccount
    }
    class BankAccount
    {
        static int Number;
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        #region Методы установки и получения значений
        public void setAccountNumber(string value)
        {
            this.accountNumber = value;
        }
        public string getAccountNumber()
        {
            return this.accountNumber;
        }
        public void setBalance(decimal value)
        {
            this.balance = value;
        }
        public decimal getBalance()
        {
            return this.balance;
        }
        public void setAccountType(AccountType value)
        {
            this.accountType = value;
        }
        public AccountType getAccountType()
        {
            return this.accountType;
        }
        #endregion

        #region Генерация нового номера
        public string GenerateNumber()
        {
            Number++;
            return Number.ToString().PadLeft(12, '0');
        }
        #endregion

        #region Конструкторы класса
        public BankAccount()
        {
            this.accountNumber = GenerateNumber();
            this.balance = 1;
            this.accountType = AccountType.PaymentAccount;
        }
        public BankAccount(decimal balance)
        {
            this.accountNumber = GenerateNumber();
            this.balance = balance;
            this.accountType = AccountType.PaymentAccount;
        }
        public BankAccount(AccountType accountType)
        {
            this.accountNumber = GenerateNumber();
            this.balance = 1;
            this.accountType = accountType;
        }
        public BankAccount(decimal balance, AccountType accountType)
        {
            this.accountNumber = GenerateNumber();
            this.balance = balance;
            this.accountType = accountType;
        }
        #endregion

        #region Свойства класса
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public AccountType AccountType
        {
            get
            {
                return this.accountType;
            }
            set
            {
                this.accountType = value;
            }
        }
        #endregion

        #region Операции со счетом
        public bool AddToAccount(decimal sum)
        {
            this.balance = this.balance + sum;
            return true;
        }
        public bool RemoveToAccount(decimal sum)
        {
            if (this.balance >= sum)
            {
                this.balance = this.balance - sum;
                return true;
            }
            return false;
        }
        public bool MoveToAccount(BankAccount bankAccount, decimal sum)
        {
            if (bankAccount.RemoveToAccount(sum)==true)
            {
                this.AddToAccount(sum);
                return true;
            }
            
            return false;
        }
        #endregion
    }
}
