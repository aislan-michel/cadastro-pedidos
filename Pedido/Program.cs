using Pedido.Entities;
using Pedido.Entities.Enums;
using System;
using System.Globalization;

namespace Pedido {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"\nData do pedido:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client (name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos produtos serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"\nEntre com os dados do produto {i}: ");
                Console.Write("Nome do produto: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              
                Product product = new Product(nameProduct, price);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem (quantity, price, product);
                
                order.AddItem(orderItem);

            }

            Console.WriteLine("\nSumário do pedido: \n");
            Console.WriteLine(order);
            Console.ReadLine();



        }
    }
}
