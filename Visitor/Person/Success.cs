using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Person
{
    public class Success:Aaction
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}\t{1}时，背后多半有一个伟大的女人",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}\t{1}时，背后多半有一个不成功的男人",concreteElementB.GetType().Name,this.GetType().Name);
        }
    }
}
