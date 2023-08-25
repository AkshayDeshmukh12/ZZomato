using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmodel
{
    public class Orderr
    {
        public void Any()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query2 = "insert into Orderr values(104,202,getdate(),740)";

            SqlCommand cmd = new SqlCommand(query2, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        public void Any2()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "update Orderr set amount=1200 where id=377";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Any3()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "Delete from Orderr where id=380";

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();


        }

    }
}

