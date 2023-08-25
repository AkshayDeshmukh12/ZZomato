using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdataacess
{
    public class Restaurant2
    {
        public void Restaurant()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "Restaurant2";
            SqlCommand cmd = new SqlCommand(query, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = "Kailash";
            cmd.Parameters.Add("@Address", System.Data.SqlDbType.VarChar).Value = "Jalana";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();

        }
        public void Restaurant1()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "Restaurant2";
            SqlCommand cmd = new SqlCommand(queryu, conn1);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 222;
            cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = "Kailash";
            cmd.Parameters.Add("@Address", System.Data.SqlDbType.VarChar).Value = "Jalana";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();

        }
        public void Restaurant3()
        {

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Restaurant2";
            SqlCommand cmd = new SqlCommand(queryd, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 225;
            cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = "Kailash";
            cmd.Parameters.Add("@Address", System.Data.SqlDbType.VarChar).Value = "Jalana";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "D";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();



        }

    }
}
