using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.EasyPrototype
{
    public abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
           // set { id = value; }
        }
        public abstract Prototype Clone();
    }
}
