using System;

namespace less_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Методы установки и получения значений
            Console.WriteLine("Информация о счете");

            BankAccount bankAccount = new();
            //bankAccount.setAccountNumber("000000000000");
            bankAccount.setBalance(1000000.01);
            bankAccount.setAccountType(AccountType.CurrentAccount);

            Console.WriteLine($"Type: {bankAccount.AccountType}\nNumber: {bankAccount.AccountNumber}\nBalance: {bankAccount.Balance}\n");
            #endregion

            #region Генерация нового номера
            Console.WriteLine("Генерация номера счета");

            BankAccount bankAccount1 = new();
            //bankAccount1.setAccountNumber(bankAccount1.GenerateNumber());
            Console.WriteLine($"Number: {bankAccount1.AccountNumber}");

            BankAccount bankAccount2 = new();
            //bankAccount2.setAccountNumber(bankAccount2.GenerateNumber());
            Console.WriteLine($"Number: {bankAccount2.AccountNumber}");

            BankAccount bankAccount3 = new();
            //bankAccount3.setAccountNumber(bankAccount3.GenerateNumber());
            Console.WriteLine($"Number: {bankAccount3.AccountNumber}");

            BankAccount bankAccount4 = new();
            //bankAccount4.setAccountNumber(bankAccount4.GenerateNumber());
            Console.WriteLine($"Number: {bankAccount4.AccountNumber}\n");
            #endregion

            #region Свойства класса
            Console.WriteLine("Свойства класса");

            BankAccount bankAccount5 = new();
            //bankAccount5.AccountNumber = "000000000000";
            bankAccount5.Balance = 1000000.01;
            bankAccount5.AccountType = AccountType.CurrentAccount;

            Console.WriteLine($"Type: {bankAccount5.AccountType}\nNumber: {bankAccount5.AccountNumber}\nBalance: {bankAccount5.Balance}\n");
            #endregion

            #region Конструкторы класса и Операции со счетом
            Console.WriteLine("Операции со счетом");

            BankAccount bankAccount7 = new(1000, AccountType.SavingsAccount);
            Console.WriteLine($"Type: {bankAccount7.AccountType}\nNumber: {bankAccount7.AccountNumber}\nBalance: {bankAccount7.Balance}");

            Console.WriteLine("Добавить на счет 7000");
            bool result = bankAccount7.AddToAccount(7000);
            Console.WriteLine($"Result: {result}\nBalance: {bankAccount7.Balance}");

            Console.WriteLine("Снять со счета 5000");
            bool result1 = bankAccount7.RemoveToAccount(5000);
            Console.WriteLine($"Result: {result1}\nBalance: {bankAccount7.Balance}");

            Console.WriteLine("Снять со счета 3500");
            bool result2 = bankAccount7.RemoveToAccount(3500);
            Console.WriteLine($"Result: {result2}\nBalance: {bankAccount7.Balance}");
            #endregion

            Console.ReadKey();
        }
    }
}
