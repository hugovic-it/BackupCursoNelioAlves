using Console132.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console132.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status){
            Moment = moment;
            Status = status;
        }

        public void addItem(OrderItem item) {
            OrderItems.Add(item); //ajustar para o Console.ReadLine()/
        }
        public void removeItem(OrderItem item){
            OrderItems.Remove(item);
        }
        public double Total() {
            double result = 0;
            foreach (OrderItem obj in OrderItems) {
                result += obj.SubTotal();
            }
            return result;
        }
    }
}
