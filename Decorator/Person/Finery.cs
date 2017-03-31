using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Person
{
    public class Finery:Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            //base.Show();
            if (this.component != null)
            {
                component.Show();
            }
        }


    }
}
