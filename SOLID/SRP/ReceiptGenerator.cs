using System.Text;

namespace SOLID.SRP
{
    public class ReceiptGenerator
    {
        public string GenerateReceipt(Order order, decimal total)
        {
            var receipt = new StringBuilder();
            receipt.AppendLine($"Order ID: {order.OrderId}");
            receipt.AppendLine("Items:");
            foreach (var item in order.Items)
            {
                receipt.AppendLine($"{item.Name} - Quantity: {item.Quantity} - Price: {item.Price:C}");
            }
            receipt.AppendLine($"Total: {total:C}");

            return receipt.ToString();
        }
    }

}
