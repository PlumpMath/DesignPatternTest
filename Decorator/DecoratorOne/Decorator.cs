using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.DecoratorOne
{
    public abstract class Decorator : Component
    {
        protected Component component = null;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            //throw new NotImplementedException();
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
