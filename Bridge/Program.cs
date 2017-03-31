using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.BaseCode;
using Bridge.Mobile;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //桥接模式
            Abstraction straction = new RefinedAbstraction();
            straction.SetImplementor(new ConcreteImplementorA());
            straction.Operation();

            straction.SetImplementor(new ConcreteImplementorB());
            straction.Operation();

            Console.WriteLine("----------------------------------------");

            HandsetBrand hb;
            hb = new HandsetBrandN();
            hb.SetHandsetSoft(new Handsetgame());
            hb.Run();
            hb.SetHandsetSoft(new HandsetAddressList());
            hb.Run();


            hb = new HandsetBrandM();
            hb.SetHandsetSoft(new Handsetgame());
            hb.Run();
            hb.SetHandsetSoft(new HandsetAddressList());
            hb.Run();

            Console.Read();
            
        }
    }
}
