using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.DecoratorOne;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //装饰者
            ConcreateComponent c = new ConcreateComponent();
            ConcreateDecoratorA ca = new ConcreateDecoratorA();
            ConcreateDecoratorB cb = new ConcreateDecoratorB();
            ca.SetComponent(c);
            cb.SetComponent(ca);
            cb.Operation();

            Console.WriteLine("----------------------------------\r\n");

            Person.Person person = new Person.Person("微软");
            Person.BigTrouser bt = new Person.BigTrouser();
            Person.TShirts ts = new Person.TShirts();

            bt.Decorate(person);
            ts.Decorate(bt);
            ts.Show();

            Console.Read();
        }
    }

}
