using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class Proxy:Subject
    {
        Subject proxy = null;
        public override void Request()
        {
            //throw new NotImplementedException();
            if (proxy == null)
            {
                proxy = new RealSubject();
            }
            proxy.Request();
        }
    }
}
