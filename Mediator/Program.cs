using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.BaseCode;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //中介者模式
            ConcreteMediator cm = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(cm);
            ConcreteColleague2 colleague2= new ConcreteColleague2(cm);

            cm.Concretecolleague1 = colleague1;
            cm.Concretecolleague2 = colleague2;

            colleague1.Send("Hello");
            colleague2.Send("Hi");

            Console.Read();

        }
    }
}
