using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.DecoratorOne
{
    public class ConcreateDecoratorB : Decorator
    {


        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象B的操作");
            this.AddedBehavior();
        }
        private void AddedBehavior()
        {
            Console.WriteLine("我是刚添加的！");
        }
    }
}
