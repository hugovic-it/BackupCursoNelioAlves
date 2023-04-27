using Console132.Entities;
using Console132.Entities.Enums;

namespace Console132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product("tv", 2000);
            //OrderItem order = new OrderItem(2, p1);
            //Console.WriteLine(order.SubTotal()); 



            Order order = new Order(DateTime.Now,OrderStatus.PENDING_PAYMENT);
            Product p1 = new Product("Tv",900.00);
            Product p2 = new Product("Cell",500.00);
            OrderItem oItem1 = new OrderItem(2, p1);
            OrderItem oItem2 = new OrderItem(3, p2);
           
            
            
            order.addItem(oItem1);
            order.addItem(oItem2);

            Console.WriteLine(order.Total());




        }
    }
}