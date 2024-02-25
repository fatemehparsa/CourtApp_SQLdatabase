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
    public class complaint:dataaccess
    {
        public int complaint_n;
        public int c_date;
        public string c_text;
        public int result_W_n;
        public int complainer_n;
        public int criminate_n;
        public int j_personnely_code;
        public int l_personnely_code;
        public int court_n;

        public void  add()
        {
            base.connect();
            string query = "insert into complaint values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
            query = string.Format(query , complaint_n,c_date,c_text,result_W_n,complainer_n,criminate_n,j_personnely_code,l_personnely_code,court_n );
            base.docommand(query);
            base.disconnect();
        }
        public void delete()
        {
            base.connect();
            string query = "delete from complaint where complaint#='{0}'";
            query = string.Format(query, complaint_n);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update complaint set c_date='{0}',c_text='{1}',result_W_n='{2}',complainer#='{3}',criminate#='{4}',j_personnely_code='{5}',l_personnely_code='{6}',court#'{7}' where complaint#='{8}'";
            query = string.Format(query,c_date, c_text, result_W_n, complainer_n, criminate_n, j_personnely_code, l_personnely_code, court_n,complaint_n);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from complaint";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
