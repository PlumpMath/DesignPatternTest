using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.BaseCode
{
    public abstract class Element
    {
        public abstract void Accept(VisitorClass visitor);
    }

}
