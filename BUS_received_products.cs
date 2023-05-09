using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_received_products
    {
        DAL_received_products Drp = new DAL_received_products();
        public List<DTO_received_products> getData(int received_id)
        {
            return Drp.getData(received_id);
        }

        public void deleteProduct(int received_id,string product_id) {
            Drp.deleteProduct(received_id, product_id);
        }

        public List<string> searchProductName(string productName)
        {
            return Drp.searchProductName(productName);
        }

        public DTO_received_products getProductInfo(string product_name)
        {
            return Drp.getProductInfo(product_name);
        }

        public void insertProduct(DTO_received_products rp,int received_id)
        {
            Drp.insertProduct(rp, received_id);
        }

        public bool isProductName(string productName)
        {
            return Drp.isProductName(productName);
        }
        
        public void updateNewQuantity(int received_id,string product_id,int oldQuantity, int quantity)
        {
            Drp.updateQuantity(received_id,product_id,oldQuantity, quantity);    
        }
    }
}
