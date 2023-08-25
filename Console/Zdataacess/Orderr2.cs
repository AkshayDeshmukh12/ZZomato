using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdataacess
{
    public class Orderr2
    {
        public void Orderr()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());


            String query = "Orderr1";
            SqlCommand cmd1 = new SqlCommand(query, conn1);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 0;
            cmd1.Parameters.Add("@CustomerrId", System.Data.SqlDbType.VarChar).Value = "102";
            cmd1.Parameters.Add("@RestaurantId", System.Data.SqlDbType.VarChar).Value = "201";
            cmd1.Parameters.Add("@amount", System.Data.SqlDbType.VarChar).Value = "840";
            cmd1.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();
        }
        public void Orderr1()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "Orderr1";

            SqlCommand cmd1 = new SqlCommand(queryu, conn1);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 343;
            cmd1.Parameters.Add("@CustomerrId", System.Data.SqlDbType.VarChar).Value = "107";
            cmd1.Parameters.Add("@RestaurantId", System.Data.SqlDbType.VarChar).Value = "203";
            cmd1.Parameters.Add("@amount", System.Data.SqlDbType.VarChar).Value = "9940";
            cmd1.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();


        }
        public void Orderr3()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Orderr1";
            SqlCommand cmd = new SqlCommand(queryd, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 392;
            cmd.Parameters.Add("@CustomerrId", System.Data.SqlDbType.VarChar).Value = "107";
            cmd.Parameters.Add("@RestaurantId", System.Data.SqlDbType.VarChar).Value = "203";
            cmd.Parameters.Add("@amount", System.Data.SqlDbType.VarChar).Value = "9940";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "D";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();

        }

    }
}
