using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight.BaseCode
{
    public class UnSharedConcreteFlyweight:Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            //throw new NotImplementedException();
            Console.WriteLine("不共享的具体Flyweight：{0}", extrinsicState);
        }
    }
}
