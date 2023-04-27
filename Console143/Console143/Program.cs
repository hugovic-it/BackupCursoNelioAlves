using Course.Entities;
using System.Globalization;
using System.Security.Principal;

namespace Console143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Mario", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: "+ sum.ToString("f2", CultureInfo.InvariantCulture));
            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list) {
                Console.WriteLine("Saldo atualizado " + acc.Number + " : " + acc.Balance);
            }
        }
    }
}