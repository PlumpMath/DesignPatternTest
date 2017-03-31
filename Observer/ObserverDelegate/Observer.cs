using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public abstract class Observer
    {
        private string name;
        private Subject sub;

        public Observer(string name,Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        protected Subject Sub
        {
            get { return sub; }
            set { sub = value; }
        }
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
       public abstract void Update();

    }
}
