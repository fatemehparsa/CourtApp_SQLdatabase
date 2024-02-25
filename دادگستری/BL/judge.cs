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
    public class judge:dataaccess
    {

        public int personnely_code;
        public string judge_name;
        public int judge_id_code;
        public string judge_gender;
        public string judge_addr;
        public int judge_license_code;
        public int court_n;

        public void  add()
        {
            base.connect();
            string query = "insert into judge values('{0}','{1}','{2}','{3}','{4}','{5}','{6}') ";
            query = string.Format(query,personnely_code);
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from lawyer where personnely_code='{0}' ";
            query = string.Format(query,personnely_code);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update judge set judge_name='{0}', judge_id_code='{1}', judge_gender='{2}', judge_addr='{3}', judge_license_code='{4}',court#='{5}',personnely_code='{6}')";
            query = string.Format(query,personnely_code);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from judge";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
