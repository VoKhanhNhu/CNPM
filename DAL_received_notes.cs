using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_received_notes
    {
        SqlConnection conn = DBAccess.Connect(); 
        public List<DTO_received_notes> getData()
        {
            try
            {
                List<DTO_received_notes> data = new List<DTO_received_notes>();
                conn.Open();
                string strCmd = "SELECT received_id,received_date FROM received_notes";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    DTO_received_notes rp = new DTO_received_notes();
                    rp.Received_id = reader1.GetInt32(reader1.GetOrdinal("received_id"));
                    rp.Received_date = reader1.GetDateTime(reader1.GetOrdinal("received_date")).ToString("MM/dd/yyyy"); 
                    data.Add(rp);
                }
                return data;
            }catch(Exception ex) { throw ex; }
            finally {
                conn.Close(); }
        }
        public int getMaxReceivedId()
        {
            try
            {
                string strCmd = "SELECT MAX(received_id) FROM received_notes";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                conn.Open();
                string rs = cmd.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(rs))
                {
                    return 1;
                }
                return Convert.ToInt32(rs) + 1;
            }
            catch (Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public void deleteReceivedNote(int received_id)
        {
            try
            {
                string strCmd = "DELETE FROM received_products WHERE received_id LIKE @received_id; DELETE FROM received_notes WHERE received_id LIKE @received_id";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramReceivedId = new SqlParameter("@received_id",SqlDbType.Int);
                paramReceivedId.Value = received_id;
                cmd.Parameters.Add(paramReceivedId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
            }catch(Exception ex) { throw ex; }
            finally { conn.Close(); }
        }

        public void insertReceivedNote(int received_id, string received_date)
        {
            try
            {
                string strCmd = "INSERT INTO received_notes VALUES(@received_id,@received_date)";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlParameter paramReceivedId = new SqlParameter("@received_id", SqlDbType.Int);
                SqlParameter paramReceivedDate = new SqlParameter("@received_date", SqlDbType.Date);
                paramReceivedId.Value = received_id;
                paramReceivedDate.Value = received_date;
                SqlParameter[] paramList = { paramReceivedDate, paramReceivedId };
                cmd.Parameters.AddRange(paramList);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { throw ex; }
            finally { conn.Close(); }
        }
    }
}
