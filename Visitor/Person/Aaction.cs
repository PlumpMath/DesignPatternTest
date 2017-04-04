using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Person
{
    public abstract class Aaction
    {
        public abstract void GetManConclusion(Man concreteElementA);
        public abstract void GetWomanConclusion(Woman concreteElementB);

    }
}
