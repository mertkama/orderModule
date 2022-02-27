using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Module_ConsoleApp
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemCount { get; set; }
        public float TotalPrice { get; set; }
        public float PaidPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public Order(int id, int userId, int itemCount, float totalPrice, float paidPrice, float discountedPrice, DateTime paidDate, DateTime orderDate, string status, string notes)
        {
            UserId = userId;
            ItemCount = itemCount;
            TotalPrice = totalPrice;
            PaidPrice = paidPrice;
            DiscountedPrice = discountedPrice;
            PaidDate = paidDate;
            OrderDate = orderDate;
            Status = status;
            Notes = notes;
            Id = id;

        }
    }
}


