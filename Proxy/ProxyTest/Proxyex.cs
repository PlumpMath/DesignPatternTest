using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.ProxyTest
{
    public class Proxyex:IGiveGift
    {
        Pursuit p = null;
        public Proxyex(SchoolGirl sg)
        {
             p = new Pursuit(sg);
        }
        public void GiveDolls()
        {
            p.GiveDolls();
        }

        public void GiveFlowers()
        {
            p.GiveFlowers();
           // throw new NotImplementedException();
        }

        public void GiveChocolate()
        {
           // throw new NotImplementedException();
            p.GiveChocolate();
        }
    }
}
