using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucQuangHuy_doan.DAL
{
    public class DBConnection
    {
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS ;Initial Catalog= LibraryManagement; User Id=sa; Password=12345";
            return conn;
        }

    }
}
