using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    internal static class DBAccess
    {
        internal static SqlConnection conn;
        internal static SqlConnection Connect()
        {
            try
            {
                string strConn = "Data Source=LAPTOP-E70FIU9O\\SQLEXPRESS02;Initial Catalog=se_project;Integrated Security=True";
                conn = new SqlConnection(strConn);
                return conn;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
