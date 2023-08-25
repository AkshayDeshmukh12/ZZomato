using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdataacess
{
    public class Restrofood2
    {
        public void Restrofood()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryrefood = "Restaurantfood";

            SqlCommand cmd = new SqlCommand(queryrefood, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@rfid", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@foodtype", System.Data.SqlDbType.VarChar).Value = "Non-vegthali";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();
        }
        public void Restrofood1()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "Restaurantfood";

            SqlCommand cmd = new SqlCommand(queryu, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@rfid", System.Data.SqlDbType.Int).Value = 540;
            cmd.Parameters.Add("@foodtype", System.Data.SqlDbType.VarChar).Value = "DalKhichadi";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();

        }
        public void Restrofood3()
        {

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Restaurantfood";
            SqlCommand cmd = new SqlCommand(queryd, conn1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.Add("@userDetailId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@rfid", System.Data.SqlDbType.Int).Value = 575;
            cmd.Parameters.Add("@foodtype", System.Data.SqlDbType.VarChar).Value = "Non-vegthali";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "D";

            conn1.Open();
            cmd.ExecuteNonQuery();
            conn1.Close();


        }

    }
}
