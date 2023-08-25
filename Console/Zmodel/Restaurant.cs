using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmodel
{
    public class Restaurant
    {
        public void Three()
        {
            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query4 = "insert into Restaurant values('Derapunjab','Sambhajinagar')";

            SqlCommand cmd3 = new SqlCommand(query4, connection2);
            connection2.Open();
            cmd3.ExecuteNonQuery();
            connection2.Close();


        }
        public void Three1()
        {
            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryu = "update Restaurant set Name='Yashwanti' where id=209";
            SqlCommand command = new SqlCommand(queryu, connection2);
            connection2.Open();
            command.ExecuteNonQuery();
            connection2.Close();

        }
        public void Three2()
        {
            SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String queryd = "delete from Restaurant where id=226";

            SqlCommand command = new SqlCommand(queryd, connection2);
            connection2.Open();
            command.ExecuteNonQuery();
            connection2.Close();

        }

    }
}
