using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_received_products
    {
        string product_id;
        int quantity;
        float price;
        string product_name;
        float total;
        public DTO_received_products(string product_id, int quantity, int price, string product_name, float total)
        {
            this.product_id = product_id;
            this.quantity = quantity;
            this.price = price;
            this.product_name = product_name;
            this.total = total;
        }
        public DTO_received_products() { }
        public string Product_id { get { return this.product_id; } set { this.product_id = value;} }
        public int Quantity { get { return this.quantity;} set { this.quantity = value;} }
        public float Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }
        public string Product_name { get { return this.product_name; } set { this.product_name = value;} }
        public float ToTal
        {
            get { return this.total; }
            set { this.total = value; }
        }
    }
}
