using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmodel
{
    public class Restrofood
    {
        public void four()
        {
            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String Query5 = "insert into Restrofood values('DalKhichdi')";
            SqlCommand cmd4 = new SqlCommand(Query5, connection3);
            connection3.Open();
            cmd4.ExecuteNonQuery();
            connection3.Close();

        }
        public void four1()
        {
            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "update Restrofood set foodtype='Southindian' where rfid=510";
            SqlCommand cmd = new SqlCommand(queryu, connection3);
            connection3.Open();
            cmd.ExecuteNonQuery();
            connection3.Close();
        }
        public void four2()
        {
            SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Delete from Restrofood where rfid=508";
            SqlCommand cmd = new SqlCommand(queryd, connection3);
            connection3.Open();
            cmd.ExecuteNonQuery();
            connection3.Close();
        }
    }

}

