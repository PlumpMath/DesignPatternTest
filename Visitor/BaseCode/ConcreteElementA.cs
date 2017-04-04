using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.BaseCode
{
    public class ConcreteElementA:Element
    {
        public override void Accept(VisitorClass visitor)
        {
            //throw new NotImplementedException();
            visitor.VisitConcreteElementA(this);
        }
    }
}
