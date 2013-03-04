using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sd_final
{
    public static class Current_User
    {
        private static long _id;
        private static long _priv;

        public static long id { get{return _id;} }
        public static long priv { get { return _priv; } }

        private static void Set_user(sd_user user)
        {
            _id = user.id;
            _priv = user.priv;

        }

        public static bool Auth(string login, string pass)
        {
            sd_user tmp_user = (from q in DB_Context.context.sd_users
                       where q.login == login && q.password == pass
                       select q).SingleOrDefault();
            if (tmp_user == null) { return false; }
            Set_user(tmp_user);
            return true;
        }
    }
}
