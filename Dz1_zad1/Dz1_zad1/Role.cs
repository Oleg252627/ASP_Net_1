using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz1_zad1
{
    public class Role
    {
        private Role() { }
        public string Name { get; private set; }

        public Role(string name)
        {
            this.Name = name;
        }

        public void Rename_Role(string name)
        {
            this.Name = name;
        }
    }
}