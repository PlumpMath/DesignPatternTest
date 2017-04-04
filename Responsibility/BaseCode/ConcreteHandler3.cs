﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Responsibility.BaseCode
{
    public class ConcreteHandler3:Handler
    {

        public override void HandleRequest(int request)
        {
            //throw new NotImplementedException();
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0}处理请求{1}.",this.GetType().Name,request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
