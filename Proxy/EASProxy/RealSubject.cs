using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class RealSubject:Subject
    {
        public override void Request()
        {
            //throw new NotImplementedException();
            Console.WriteLine("真是的请求");
        }
    }
}
