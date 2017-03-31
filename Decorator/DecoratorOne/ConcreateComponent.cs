using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.DecoratorOne
{
    public class ConcreateComponent : Component
    {
        public override void Operation()
        {
            //throw new NotImplementedException();
            Console.WriteLine("具体对象操作");
        }
    }

}
