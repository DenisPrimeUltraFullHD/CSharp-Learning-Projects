using System;

namespace cod
{
    class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Deposit(decimal amount, string description)
        {
            balance += amount;
            System.Console.WriteLine($"{description}");
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
                return false;
        }
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance >= 0 ? initialBalance : 0;
            Console.WriteLine($"Счёт открыт, баланс {balance}");
        }
        public decimal GetBalance()
        {
            return balance;
        }

    }
    class Program
    {
        static void Main()
        {
            var bank = new BankAccount(44m);

            bank.Deposit(10m);

            bank.Deposit(10m, $"Депозит за апрель: {10m}");


            bool ok1 = bank.Withdraw(100m);
            Console.WriteLine(ok1 ? "Снятие 100 прошло" : "Снятие 100 не удалось");
            bool ok2 = bank.Withdraw(1m);
            Console.WriteLine(ok2 ? "Снятие 1 прошло" : "Снятие 1 не удалось");

            Console.WriteLine($"Текущий баланс: {bank.GetBalance()}");
        }
    }
}