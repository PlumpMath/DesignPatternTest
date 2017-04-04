using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight.WebSite
{
    public class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            //set { name = value; }
        }
        public User(string name)
        {
            this.name = name;
        }
    }
}
