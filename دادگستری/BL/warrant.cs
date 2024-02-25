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
    public class warrant:dataaccess
    {
        public int w_n;
        public int pronouncement_date;
        public int fulfil_date;
        public int warrant_text;

        public void  add()
        {
            base.connect();
            string query = "insert into warrant values('{0}','{1}','{2}','{3}')";
            query = string.Format(query,w_n,pronouncement_date,fulfil_date,warrant_text);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from warrant where w#={0}";
            query = string.Format(query,w_n);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update warrant set pronouncement_date='{0}',fulfil_date='{1}',warrant_text='{2}' where w#={3}";
            query = string.Format(query,w_n);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from warrant";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
