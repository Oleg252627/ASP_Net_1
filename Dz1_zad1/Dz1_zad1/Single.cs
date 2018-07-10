using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz1_zad1
{
    public class Single
    {
        private static Single single;
        private List<User> users;
        private int count;
        private Single()
        {
            users=new List<User>();
            count = 1;
        }

        public static Single GetSingle()
        {
            if (single == null)
            {
                single=new Single();
            }

            return single;
        }

        public void Set_User(string log, string pasword, string name)
        {
            User user = new User(count,log,pasword);
            user.Set_role(name);
            users.Add(user);
            count++;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}