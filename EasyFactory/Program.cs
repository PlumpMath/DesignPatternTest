using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂
            Operation oper = Factory.getOperation("+");
            oper.Numberone = 2;
            oper.Numbertwo = 3;
            Console.WriteLine( oper.GetRestult());

            Console.Read();
            
        }
    }
}
