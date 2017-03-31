using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.ProxyTest
{
    public class Pursuit : IGiveGift
    {

        SchoolGirl sg = null;
        public Pursuit(SchoolGirl sg)
        {
            this.sg = sg;
        }
        public void GiveDolls()
        {
            //throw new NotImplementedException();
            Console.WriteLine(sg.Name+"送你的洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(sg.Name + "送你的玫瑰花");
           // throw new NotImplementedException();
        }

        public void GiveChocolate()
        {
            Console.WriteLine(sg.Name + "送你的巧克力");
            //throw new NotImplementedException();
        }
    }
}
