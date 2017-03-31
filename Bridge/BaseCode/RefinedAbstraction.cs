using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.BaseCode
{
    public class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
           // base.Operation();
            implementor.Operation();
        }
    }
}
