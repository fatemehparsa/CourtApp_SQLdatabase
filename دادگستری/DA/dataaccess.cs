using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace دادگستری.DA
{
    public class dataaccess
    {
        SqlConnection con;
        SqlCommand cmd; 
        SqlDataAdapter da;
        DataTable dt;
        
        public dataaccess()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            cmd.Connection = con;
            da.SelectCommand = cmd;

        }
    
        public void  connect()
        {
            con.ConnectionString = "Data Source=Lenovo-z5070;Initial Catalog=court;Integrated Security=True";
            con.Open();
        }

        public void disconnect()
        {
            con.Close();

        }

        public DataTable select(string query)
        {
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
         
        public void docommand(string query)
        {
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
    }
}
