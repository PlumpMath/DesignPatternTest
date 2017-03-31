using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Other
{
    public class StackObserver:Observer
    {
        public StackObserver(string name,Subject sub)
            :base(name,sub)
        { 
        
        }
        public override void Update()
        {
           // throw new NotImplementedException();
            Console.WriteLine("{0} {1}关闭股票行情继续工作!",this.Name,this.Sub.subjectstate);
        }
    }
}
