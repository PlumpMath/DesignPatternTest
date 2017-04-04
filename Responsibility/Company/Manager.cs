using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Responsibility.Company
{
    public abstract class Manager
    {
        protected string name;

        protected Manager Superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.Superior = superior;
        }
        public abstract void RequestApploactions(Request request);
    }
}
