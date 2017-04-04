using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.BaseCode
{
    public class ConcreteVisitor1:VisitorClass
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}被{1}访问",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}被{1}访问", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
