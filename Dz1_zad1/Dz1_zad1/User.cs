using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz1_zad1
{
    public class User
    {
        private Role role;
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pasword { get; set; }

        public User(int id, string login, string pasword)
        {
            Id = id;
            Login = login == "" ? "null" : login;
            Pasword = pasword == "" ? "null" : pasword;
        }

        public void Set_role(string name)
        {
            role=new Role(name);
        }

        public Role Get_role()
        {
            return role;
        }

        public void Rename_User(string login,string pasword, string rol)
        {
            Login = login == "" ? "null" : login;
            Pasword = pasword == "" ? "null" : pasword;
            role.Rename_Role(rol);
        }
    }
}