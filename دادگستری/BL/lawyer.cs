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
    public class lawyer:dataaccess
    {
        public int personnely_code ;
        public string lawyer_name;
        public int lawyer_id_code;
        public string lawyer_gender;
        public string lawyer_addr;
        public int agancy_license_code;
        public int court_n;


        public void  add()
        {
            base.connect();
            string query = "insert into lawyer values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            query = string.Format(query, personnely_code, lawyer_name, lawyer_id_code, lawyer_gender, lawyer_addr, agancy_license_code,court_n);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from lawyer where personnely_code='{0}' ";
            query = string.Format(query, personnely_code);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update lawyer set lawyer_name='{0}', lawyer_id_code='{1}', lawyer_gender='{2}', lawyer_addr='{3}', agancy_license_code='{4}',court#='{5}',personnely_code='{6}')";
            query = string.Format(query, personnely_code);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from lawyer";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
