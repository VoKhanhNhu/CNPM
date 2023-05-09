using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_received_products
    {
        SqlConnection conn = DBAccess.Connect();

        public List<DTO_received_products> getData(int received_id)
        {
            try
            {
                conn.Open();
                string strCmd = "SELECT received_products.product_id,received_products.quantity,products.product_name,products.price FROM received_products INNER JOIN products ON received_products.product_id = products.product_id WHERE received_id like @received_id";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramReceived_id = new SqlParameter("@received_id", SqlDbType.Int);
                paramReceived_id.Value = received_id;
                cmd.Parameters.Add(paramReceived_id);
                SqlDataReader reader = cmd.ExecuteReader();
                List<DTO_received_products> Drp = new List<DTO_received_products>();
                while (reader.Read())
                {
                    DTO_received_products rp = new DTO_received_products();
                    rp.Product_id = reader.GetString(reader.GetOrdinal("product_id"));
                    rp.Quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                    rp.Price = (float)reader.GetDouble(reader.GetOrdinal("price"));
                    rp.Product_name = reader.GetString(reader.GetOrdinal("product_name"));
                    rp.ToTal = rp.Price * rp.Quantity;
                    Drp.Add(rp);
                }
                reader.Close();
                return Drp;
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }
        public bool hasProductName(int received_id, string product_id)
        {
            try
            {
                conn.Open();
                string strCmd = "SELECT COUNT(1) FROM received_products WHERE received_id LIKE @received_id AND product_id LIKE @product_id";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramReceivedId = new SqlParameter("@received_id", SqlDbType.Int);
                SqlParameter paramProductId = new SqlParameter("@product_id", SqlDbType.VarChar);
                paramReceivedId.Value = received_id;
                paramProductId.Value = product_id;
                SqlParameter[] paramList = { paramReceivedId, paramProductId };
                cmd.Parameters.AddRange(paramList);
                int rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                return (rows > 0);
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }
        public void insertProduct(DTO_received_products rp, int received_id)
        {
            try
            {
                string strCmd = "";
                if (!hasProductName(received_id, rp.Product_id))
                    strCmd = @"INSERT INTO received_products(received_id,product_id,quantity) VALUES(@received_id,@product_id,@quantity); UPDATE products SET products.quantity = products.quantity + @quantity WHERE products.product_id LIKE @product_id";
                else
                    strCmd = @"UPDATE received_products SET received_products.quantity = received_products.quantity + @quantity WHERE received_id LIKE @received_id AND product_id LIKE @product_id; UPDATE products SET products.quantity = products.quantity + @quantity WHERE products.product_id LIKE @product_id";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramReceivedId = new SqlParameter("@received_id", SqlDbType.Int);
                SqlParameter paramProducId = new SqlParameter("@product_id", SqlDbType.VarChar);
                SqlParameter paramQuantity = new SqlParameter("@quantity", SqlDbType.Int);
                paramProducId.Value = rp.Product_id;
                paramQuantity.Value = rp.Quantity;
                paramReceivedId.Value = received_id;
                SqlParameter[] paramList = { paramProducId, paramQuantity, paramReceivedId };
                cmd.Parameters.AddRange(paramList);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }
        public void deleteProduct(int received_id, string product_id)
        {
            try
            {
                string strCmd1 = "SELECT received_products.quantity FROM received_products WHERE received_products.received_id LIKE @received_id AND product_id LIKE @product_id";
                SqlCommand cmd1 = new SqlCommand(strCmd1, conn);
                SqlParameter paramProductId = new SqlParameter("@product_id", SqlDbType.VarChar);
                SqlParameter paramReceivedId = new SqlParameter("@received_id", SqlDbType.Int);
                paramProductId.Value = product_id;
                paramReceivedId.Value = received_id;
                SqlParameter[] paramList1 = { paramReceivedId, paramProductId };
                cmd1.Parameters.AddRange(paramList1);
                conn.Open();
                int quantity = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                conn.Close();

                string strCmd = "DELETE FROM received_products WHERE product_id like @product_id1 AND received_id like @received_id1; UPDATE products SET products.quantity = products.quantity - @quantity1 WHERE products.product_id LIKE @product_id1";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramProductId1 = new SqlParameter("@product_id1", SqlDbType.VarChar);
                SqlParameter paramReceivedId1 = new SqlParameter("@received_id1", SqlDbType.Int);
                SqlParameter paramQuantity = new SqlParameter("@quantity1", SqlDbType.Int);
                paramQuantity.Value = quantity;
                paramProductId1.Value = product_id;
                paramReceivedId1.Value = received_id;
                SqlParameter[] paramList = { paramReceivedId1, paramProductId1, paramQuantity };
                cmd.Parameters.AddRange(paramList);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public List<string> searchProductName(string productName)
        {
            try
            {
                conn.Open();
                List<string> Drp = new List<string>();
                string strCmd = @"SELECT products.product_name FROM products WHERE product_name LIKE @searchPattern";
                string searchPattern = "";
                char[] s = productName.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == 0)
                    {
                        searchPattern += @"%" + s[i] + @"%";
                    }
                    else
                    {
                        searchPattern += s[i] + @"%";
                    }
                }
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                cmd.Parameters.AddWithValue("@searchPattern", searchPattern);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Drp.Add(reader.GetString(reader.GetOrdinal("product_name")));
                }
                return Drp;
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public DTO_received_products getProductInfo(string productName)
        {
            try
            {
                conn.Open();
                string strCmd = "SELECT products.product_id,products.product_name,products.price FROM products WHERE product_name like @product_name";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramProductName = new SqlParameter("@product_name", SqlDbType.VarChar);
                paramProductName.Value = productName;
                cmd.Parameters.Add(paramProductName);
                SqlDataReader reader = cmd.ExecuteReader();
                DTO_received_products rp = new DTO_received_products();
                while (reader.Read())
                {
                    rp.Product_id = reader.GetString(reader.GetOrdinal("product_id"));
                    rp.Price = (float)reader.GetDouble(reader.GetOrdinal("price"));
                    rp.Product_name = reader.GetString(reader.GetOrdinal("product_name"));
                }
                return rp;
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public bool isProductName(string productName)
        {
            try
            {
                conn.Open();
                string strCmd = "SELECT COUNT(1) FROM products WHERE product_name like @product_name";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramProductName = new SqlParameter("@product_name", SqlDbType.VarChar);
                paramProductName.Value = productName;
                cmd.Parameters.Add(paramProductName);
                int row = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                return row > 0;
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public void updateQuantity(int received_id, string product_id,int oldQuantiy, int newQuantity)
        {
            try
            {
                conn.Open();
                string strCmd = "UPDATE received_products SET quantity = @newQuantity WHERE received_id LIKE @received_id AND product_id LIKE @product_id; UPDATE products SET products.quantity = products.quantity - @oldQuantity + @newQuantity WHERE products.product_id LIKE @product_id";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramQuantity = new SqlParameter("@newQuantity", SqlDbType.Int);
                SqlParameter paramProductId = new SqlParameter("@product_id", SqlDbType.VarChar);
                SqlParameter paramReceivedId = new SqlParameter("@received_id", SqlDbType.Int);
                SqlParameter paramOldQuantity = new SqlParameter("@oldQuantity", SqlDbType.Int);
                paramReceivedId.Value = received_id;
                paramProductId.Value = product_id;
                paramQuantity.Value = newQuantity;
                paramOldQuantity.Value = oldQuantiy;
                SqlParameter[] paramList = {paramQuantity, paramProductId,paramReceivedId,paramOldQuantity};
                cmd.Parameters.AddRange(paramList);
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }  
            finally { conn.Close(); }
        }
    }
}
