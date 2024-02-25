using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using دادگستری.BL;
using دادگستری.DA;
using System.Data;
using System.Data.SqlClient;

namespace دادگستری.BL
{
    public class function12:dataaccess
    {
        public int f1data;
        public int f2data;





        public DataTable f1()
        {
            base.connect();
            string query = "select * from f({0})";
            query = string.Format(query, f1data);
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
        public DataTable f2()
        {
            base.connect();
            string query = "select * from f2({0})";
            query = string.Format(query, f2data);
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
