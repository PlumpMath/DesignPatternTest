using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxy.ProxyTest;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //代理
            Proxy prox = new Proxy();
            prox.Request();


            SchoolGirl sg = new SchoolGirl() {Name="林心如" };

            Proxyex proxy = new Proxyex(sg);
            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();

            Console.Read();
        }
    }
}
