using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdataacess
{
    public class Payment2
    {
        public void Payment()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "payment1";
            SqlCommand cmd2 = new SqlCommand(query, conn1);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd2.Parameters.Add("@paymentDetailId", System.Data.SqlDbType.Int).Value=0;
            cmd2.Parameters.Add("@pid", System.Data.SqlDbType.Int).Value = 0;
            cmd2.Parameters.Add("@paymenttype", System.Data.SqlDbType.VarChar).Value = "Cash";
            cmd2.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";
            conn1.Open();
            cmd2.ExecuteNonQuery();
            conn1.Close();

        }
        public void Payment1()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());


            String queryu = "payment1";

            SqlCommand cmd1 = new SqlCommand(queryu, conn1);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd2.Parameters.Add("@paymentDetailId", System.Data.SqlDbType.Int).Value=0;
            cmd1.Parameters.Add("@pid", System.Data.SqlDbType.Int).Value = 554;
            cmd1.Parameters.Add("@paymenttype", System.Data.SqlDbType.VarChar).Value = "Offline";
            cmd1.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";
            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();


        }
        public void Payment3()
        {

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "payment1";

            SqlCommand cmd1 = new SqlCommand(queryd, conn1);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd2.Parameters.Add("@paymentDetailId", System.Data.SqlDbType.Int).Value=0;
            cmd1.Parameters.Add("@pid", System.Data.SqlDbType.Int).Value = 550;
            cmd1.Parameters.Add("@paymenttype", System.Data.SqlDbType.VarChar).Value = "Offline";
            cmd1.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "d";
            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();


        }

    }
}
