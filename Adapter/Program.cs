using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adapter.Easy;
using Adapter.NBA;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //适配器模式

            Target target = new Adpter();
            target.Request();



            Player paly = new Forwards("乔丹");
            paly.Addach();


            paly = new Translation("姚明");
            paly.Addach();
            paly.Defense();

            Console.Read();
        }
    }
}
