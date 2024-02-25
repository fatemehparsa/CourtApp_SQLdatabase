using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace دادگستری.DA
{
    public class loginDA
    {
        public String user;
        public String pass;
        public static bool Realize(loginDA L)
        {
            bool R = false;
            String P = L.pass;
            String U = L.user;
            if (U == "user1" && P == "1234")

            {
                R = true;
            }


            return R;
        }
    }
}
