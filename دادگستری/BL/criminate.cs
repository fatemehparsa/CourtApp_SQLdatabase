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
    public class criminate : dataaccess
    {

        public int criminate_number;
        public string criminate_name;
        public string criminate_id_code;
        public string criminate_addr;
        public int criminate_phone_n;
        public string criminate_gender;

        public void add()
        {
            base.connect();
            string query = "insert into criminate values('{0}','{1}','{2}','{3}','{4}','{5}') ";
            query = string.Format(query, criminate_number, criminate_name, criminate_id_code,criminate_addr, criminate_phone_n, criminate_gender);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from criminate where criminate#={0}";
            query = string.Format(query, criminate_number);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "updete criminate set criminate_name='{0}',criminate_addr'{1}', criminate_id_code='{2}',criminate_phone_n='{3}', criminate_gender='{4}' where criminate#='{5}'";
            query = string.Format(query, criminate_name, criminate_addr, criminate_id_code, criminate_phone_n, criminate_gender, criminate_number);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from criminate";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
