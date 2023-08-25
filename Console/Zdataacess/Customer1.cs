using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Zdataacess
{
    public class Customer1
    {
        public void Custome()
        {

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query1 = "Customer3";
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand(query1, conn1);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 0;
            cmd1.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = "Ashok";
            cmd1.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar).Value = "More";
            cmd1.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = "asghf@gmail.com";
            cmd1.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = "4521826";
            cmd1.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            cmd1.ExecuteNonQuery();
            conn1.Close();

        }
        public void Custome1()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "Customer3";
            conn1.Open();
            SqlCommand cmd = new SqlCommand(queryu, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 137;
            cmd.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = "Vinod";
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar).Value = "Khanna";
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = "attryf@gmail.com";
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = "4548926";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "U";
            cmd.ExecuteNonQuery();
            conn1.Close();


        }
        public void Custome2()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Customer3";
            SqlCommand cmd = new SqlCommand(queryd, conn1);
            conn1.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 151;
            cmd.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = "Vinod";
            cmd.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar).Value = "Khanna";
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = "attryf@gmail.com";
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = "4548926";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "D";
            cmd.ExecuteNonQuery();
            conn1.Close();


        }


    }
}
