using System;

namespace Order_Module_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(
                155,1,15,(float)54.5,(float)12.7,25
                ,new DateTime(2022,02,26)
                ,new DateTime(2022,02,27)
                ,"sipariş tamamlandı."
                ,"ürün satıldı.");

            Console.WriteLine("Order1.Id: " + order1.Id);
            Console.WriteLine("Order1.UserId: " + order1.UserId);
            Console.WriteLine("Order1.ItemCount: " + order1.ItemCount);
            Console.WriteLine("Order1.TotalPrice: " + order1.TotalPrice);
            Console.WriteLine("Order1.PaidPrice: " + order1.PaidPrice);
            Console.WriteLine("Order1.DiscountedPrice: " + order1.DiscountedPrice);
            Console.WriteLine("Order1.PaidDate: " + order1.PaidDate.ToLongDateString());
            Console.WriteLine("Order1.OrderDate: " + order1.OrderDate.ToLongDateString());
            Console.WriteLine("Order1.Status: " + order1.Status);
            Console.WriteLine("Order1.Notes: " + order1.Notes);
            Console.WriteLine("Order1.Id: " + order1.Id);

            Order order2 = new Order(2,2,20,(float)28.78,(float)78.74, 30, new DateTime(2022, 02, 26)
                , new DateTime(2022, 02, 27)
                , "2. sipariş tamamlandı."
                , "2.ürün satıldı.");
        }
    }
}
