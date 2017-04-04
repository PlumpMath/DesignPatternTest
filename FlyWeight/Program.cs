using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.BaseCode;
using FlyWeight.WebSite;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            //享元模式

            int extrinsicState = 22;
            FlyWeightFactory fact = new FlyWeightFactory();
            Flyweight fx = fact.GetFlayWeight("x");
            fx.Operation(--extrinsicState);

            Flyweight fy = fact.GetFlayWeight("y");
            fy.Operation(--extrinsicState);

            Flyweight fz = fact.GetFlayWeight("z");
            fz.Operation(--extrinsicState);


            UnSharedConcreteFlyweight unsharedFlyweight = new UnSharedConcreteFlyweight();
            unsharedFlyweight.Operation(--extrinsicState);


            Console.WriteLine("********************************************");


            WebSiteFactory wf = new WebSiteFactory();
            WebSiteClass wc = wf.getWebSiteCategory("产品展示");
            wc.Use(new User("小鸟"));

            WebSiteClass wc1 = wf.getWebSiteCategory("产品展示");
            wc.Use(new User("大鸟"));


            WebSiteClass bg = wf.getWebSiteCategory("博客");
            wc.Use(new User("科技"));

            Console.Read();

            
        }
    }
}
