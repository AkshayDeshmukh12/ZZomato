using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmodel
{
    public class Customer
    {

        public void Cus()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query2 = "insert into Customer values('Nilesh','Deshmukh','asedrft@gmail.com','74581')";

            SqlCommand cmd = new SqlCommand(query2, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        public void Cus1()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "update Customer set firstName='Suresh' where id=140";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Cus2()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            String query = "Delete from Customer where id=155";

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();


        }
    }
}
