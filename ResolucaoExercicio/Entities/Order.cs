using ResolucaoExercicio.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ResolucaoExercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        List<OrderItem> orderitem = new List<OrderItem>();
        public void AddItem(OrderItem item)
        {
            orderitem.Add(item);
        }

        public void RevomeItem(OrderItem item)
        {
            orderitem.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in orderitem)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in orderitem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
