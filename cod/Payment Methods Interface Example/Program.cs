using System;
using System.Collections.Generic;

namespace cod
{
    interface IPayable
    {
        void Pay(decimal amount);
    }
    class CreditCard : IPayable
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"Оплата с кредитной карты на сумму {amount}");
        }
    }
    class PayPal : IPayable
    {
        public void Pay(decimal amount)
        {
            System.Console.WriteLine($"Оплата через PayPal на сумму {amount}");
        }
    }
    class Program
    {
        static void Main()
        {
            var credit = new CreditCard();
            var paypal = new PayPal();
            List<IPayable> pays = { credit, paypal };
            foreach (var metods in pays)
            {
                metods.Pay(200);
            }
        }
    }
}