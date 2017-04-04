using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.BaseCode;
using Visitor.Person;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //访问者模式
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            o.Accept(v1);
            //o.Accept();



            ObjectStructurePerson person = new ObjectStructurePerson();
            person.Attach(new Man());
            person.Attach(new Woman());

            Success sc = new Success();
            person.Display(sc);

            Console.Read();
        }
    }
}
