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
    public class court:dataaccess
    {

        public int court_number;
        public string court_name;
        public string court_addr;




        public void add()
        {
            base.connect();
            string query = "insert into court values('{0}','{1}','{2}') ";
            query = string.Format(query,court_number,court_name,court_addr);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from court where court#={0}";
            query = string.Format(query,court_number);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "updete court set court_name='{0}', court_addr='{1}' where court#={2}";
            query = string.Format(query, court_name, court_addr, court_number);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from court";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }



    }
}
