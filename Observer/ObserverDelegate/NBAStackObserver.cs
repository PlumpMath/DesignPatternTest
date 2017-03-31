using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public class NBAStackObserver
    {
        private string name;
        private Subject sub;
        public NBAStackObserver(string name,Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseNBADirectseeding()
        {
            Console.WriteLine("{0} {1}关闭NBA直播继续工作!", this.name, this.sub.subjectsate);
        }
    }
}
