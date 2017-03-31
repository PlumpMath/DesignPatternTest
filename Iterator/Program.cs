using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Base;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //迭代器模式

            ConcreateAggregate aggregate = new ConcreateAggregate();
            aggregate[0] = "长腿美女";
            aggregate[1] = "帅哥";
            aggregate[2] = "小偷";
            aggregate[3] = "警察";
            aggregate[3] = "内部员工售票员";

            //Iterator.Base.Iterator iterator = new ConcreteInerator(aggregate);
            Iterator.Base.Iterator iterator = new ConcreteIneratorDesc(aggregate);
            object item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine("{0},请您买票！",iterator.CurrentItem());
                iterator.Next();
            }

            Console.Read();

        }
    }
}
