using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmodel
{
    public class Payment
    {
        public void Two()
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String Query3 = "insert into Payment values('online')";
            SqlCommand cmd2 = new SqlCommand(Query3, connection1);
            connection1.Open();
            cmd2.ExecuteNonQuery();
            connection1.Close();
        }
        public void Two1()
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "Update Payment set paymenttype='Offline' where pid=421";

            SqlCommand cmd = new SqlCommand(queryu, connection1);
            connection1.Open();
            cmd.ExecuteNonQuery();
            connection1.Close();


        }
        public void Two2()
        {
            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "Delete from Payment where pid=407";

            SqlCommand command = new SqlCommand(queryd, connection1);
            connection1.Open();
            command.ExecuteNonQuery();
            connection1.Close();

        }

    }
}
