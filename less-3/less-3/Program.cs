using System;
using System.IO;

namespace less_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Перевод со счета на счет
            string sum;

            Console.WriteLine("Введите сумму на счете #1:");
            sum = Console.ReadLine();
            BankAccount bankAccount1 = new(decimal.Parse(sum), AccountType.SavingsAccount);

            Console.WriteLine("Введите сумму на счете #2:");
            sum = Console.ReadLine();
            BankAccount bankAccount2 = new(decimal.Parse(sum), AccountType.SavingsAccount);

            Console.WriteLine("Введите сумму для перевода со счета #1 на счет #2:");
            sum = Console.ReadLine();
            if (bankAccount2.MoveToAccount(bankAccount1, decimal.Parse(sum)) == false)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                Console.WriteLine($"Результат: счет #1 (sum {bankAccount1.Balance}), счет #2 (sum {bankAccount2.Balance})");
            }

            Console.WriteLine(new String('-', 50));
            #endregion

            #region Строка в обратном порядке
            Console.WriteLine("Введите строку:");
            string strInvert = InvertString(Console.ReadLine());
            Console.WriteLine($"Строка в обратном порядке:\n{strInvert}");

            Console.WriteLine(new String('-', 50));
            #endregion

            #region Работа со строками
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();
            Console.WriteLine("Введите путь к новому файлу:");
            string filePathNew = Console.ReadLine();
            try
            {
                StreamReader streamReader = new StreamReader(filePath);
                StreamWriter streamWriter = new StreamWriter(filePathNew);

                string s = streamReader.ReadLine();

                while (s != null)
                {
                    SearchMail(ref s);
                    streamWriter.WriteLine(s);
                    s = streamReader.ReadLine();
                }

                streamWriter.Close();

                Console.WriteLine("Операция выполнена успешно!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка обработки!");
                //throw;
            }
            #endregion

            Console.ReadKey();
        }
        public static string InvertString(string str)
        {
            string strInvert = "";

            for (int i = str.Length; i > 0 ; i--)
            {
                strInvert = strInvert + str[i - 1];
            }

            return strInvert;
        }
        public static void SearchMail(ref string s)
        {
            s = s.Substring(s.IndexOf('&') + 1).Trim();
        }
    }
}
