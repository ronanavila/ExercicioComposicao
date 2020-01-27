using ResolucaoExercicio.Entities;
using ResolucaoExercicio.Entities.Enum;
using System;

namespace ResolucaoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth (DD/MM//YYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many item to this order: ");
            int quantity = int.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);
            Order order = new Order();
            order.Status = status;
            order.Client = client;

            for (int i = 1; i <= quantity; i++)
            {

                Console.WriteLine($"Enter item #{i} data: ");
                Console.Write("Product name: ");
                string productname = Console.ReadLine();
                Console.Write("Product price: ");
                double productprice = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                int productquantity = int.Parse(Console.ReadLine());
                OrderItem orderitem = new OrderItem(productquantity, productprice);
                Product prod = new Product(productname, productprice);
                orderitem.Product = prod;
                order.AddItem(orderitem);
                order.Moment = DateTime.Now;
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(order.ToString());



        }
    }
}
