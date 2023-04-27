using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console132.Entities
{
    internal class OrderItem
    {

        private int quantity { get; set; }
        private double price { get; set; }
        private Product product { get; set; }


        public OrderItem(){
        }

        public OrderItem(int quantity,  Product product)
        {
            this.quantity = quantity;
            price = product.Price;
            this.product = product;
        }

        public Double SubTotal() {
            return quantity * price;
        }


        public override string ToString()
        {
            return "Product " + product + " Quantity: " + quantity + " Price: " + price + " ";
        }
    }
}
