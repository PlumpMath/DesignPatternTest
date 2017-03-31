using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.BaseCode
{
    public class ConcreteImplementorB:Implementor
    {
        public override void Operation()
        {
           // throw new NotImplementedException();
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}
