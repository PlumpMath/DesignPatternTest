using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public class StackObserver
    {
        private string name;
        private Subject sub;
        public StackObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseStackMarket()
        {
            Console.WriteLine("{0} {1}关闭股票行情继续工作!", this.name, this.sub.subjectsate);
        }
    }
}
