using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Person
{
    public abstract class Person
    {
        public abstract void Accept(Aaction visitor);
    }
}
