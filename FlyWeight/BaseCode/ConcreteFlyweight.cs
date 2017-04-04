using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight.BaseCode
{
    public class ConcreteFlyweight:Flyweight
    {

        public override void Operation(int extrinsicState)
        {
            //throw new NotImplementedException();
            Console.WriteLine("具体的Flyweight：{0}", extrinsicState);
        }
    }
}
