using System;
using System.Collections.Generic;


namespace cod
{
    public class Payment
    {
        public virtual void Process() { }
    }
    public class CreditCardPayment : Payment
    {
        public override void Process()
        {
            System.Console.WriteLine("Оплатить кредитной картой?");
        }
    }
    public class PaypalPayment : Payment
    {
        public override void Process()
        {
            System.Console.WriteLine("Оплатить с помощью Pay Pal?");
        }
    }
    public class BankTransferPayment : Payment
    {
        public override void Process()
        {
            System.Console.WriteLine("Сделать перевод на счёт другого банка?");
        }
    }
    class Program
    {
        static void Main()
        {

            static void Checkout(List<Payment> payments)
            {
                foreach (var i in payments)
                {
                    i.Process();
                }
            }
            var payments = new List<Payment>
            {
                new CreditCardPayment(),
                new PaypalPayment(),
                new BankTransferPayment()
            };

            Checkout(payments);






        }
    }
}