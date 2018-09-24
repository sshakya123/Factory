using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPES;

namespace DAL
{
    public class EMPDAL:IEMPLDAL
    {
      public int CheckEmployees(IEMPLBO obj)
        {
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            SqlCommand comm = new SqlCommand();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "spCheck";
            comm.Parameters.AddWithValue("@username", obj.Username);
            comm.Parameters.AddWithValue("@password", obj.Password);
            comm.Connection = conn;

            int reader = Convert.ToInt32(comm.ExecuteScalar());
            if (reader > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
