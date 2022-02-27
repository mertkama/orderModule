using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Module_ConsoleApp
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float PaidPrice { get; set; }
        public float Amount { get; set; }
        public string AmountType { get; set; }
        public string ProductJson { get; set; }
        public OrderItem(int id, int orderId, string productId, float price, float discount, float paidPrice, float amount, string amountType, string productJson)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
            Discount = discount;
            Amount = amount;
            AmountType = amountType;
            ProductJson = productJson;
        }
    }
}
