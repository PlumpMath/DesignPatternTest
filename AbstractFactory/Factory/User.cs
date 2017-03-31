using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class User
    {
        private string id;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
