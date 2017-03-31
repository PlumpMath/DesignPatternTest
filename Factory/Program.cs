using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Factory;
 

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //工厂模式
            IFactory factory = new Factory.AddFactory();
            Operation oper = factory.getOperation();
            oper.Numberone = 1;
            oper.Numbertwo = 3;
            Console.WriteLine(oper.GetRestult());
            Console.Read();
        }
    }
}
