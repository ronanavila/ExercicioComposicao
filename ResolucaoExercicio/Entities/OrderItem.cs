using System.Text;

namespace ResolucaoExercicio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", " + "$" + Price + ", Quantity: " + Quantity);
            sb.Append(", Subtotal $" + SubTotal().ToString("F2"));
            return sb.ToString();
        }
    }
}
