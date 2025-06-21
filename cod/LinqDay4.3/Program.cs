using System;
using System.Collections.Generic;
using System.Linq;

namespace cod
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Product { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Client> clients = new List<Client>
            {
                new Client {Id = 1, Name = "Denis"},
                new Client {Id = 2, Name = "Daniil"},
                new Client {Id = 3, Name = "Alexandr"},
                new Client {Id = 4, Name = "Maxim"},
                new Client {Id = 5, Name = "Senya"}
            };
            List<Order> orders = new List<Order>
            {
                new Order {Id = 1, ClientId = 1, Product ="Laptop"},
                new Order {Id = 2, ClientId = 2, Product ="Monitor"},
                new Order {Id = 3, ClientId = 5, Product ="Iphone"},
                new Order {Id = 4, ClientId = 1, Product ="Samsung"},
                new Order {Id = 5, ClientId = 3, Product ="Dell"}
            };

            var inner = clients.Join(orders,
            c => c.Id,
            o => o.ClientId,
            (c, o) => new
            {
                ClientName = c.Name,
                Product = o.Product
            });

            var OrdersCount = inner
            .GroupBy(x => x.ClientName)
            .Select(g => new
            {
                Client = g.Key,
                Count = g.Count()
            });

            System.Console.WriteLine("Количество заказов на клиента: ");

            foreach (var item in OrdersCount)
            {
                System.Console.WriteLine($"{item.Client} сделал заказов в количестве {item.Count}");
            }
        }
    }
}