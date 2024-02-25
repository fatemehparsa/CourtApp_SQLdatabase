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
    public class complainer:dataaccess
    {

        public int complainer_number;
        public string complainer_name;
        public string complainer_addr;
        public string complainer_id_code;
        public int complainer_phone_n;
        public string complainer_gender;



        public void add()
        {
            base.connect();
            string query = "insert into complainer values('{0}','{1}','{2}','{3}','{4}','{5}') ";
            query = string.Format(query, complainer_number, complainer_name, complainer_addr, complainer_id_code,complainer_phone_n, complainer_gender);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from complainer where complainer#={0}";
            query = string.Format(query, complainer_number);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "updete complainer set complainer_name='{0}',complainer_addr'{1}', complainer_id_code='{2}',complainer_phone_n='{3}', complainer_gender='{4}' where complainer#='{5}'";
            query = string.Format(query,  complainer_name, complainer_addr, complainer_id_code, complainer_phone_n, complainer_gender, complainer_number);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from complainer";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
