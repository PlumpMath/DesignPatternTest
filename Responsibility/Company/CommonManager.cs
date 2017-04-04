using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Responsibility.Company
{
    public class CommonManager:Manager
    {
        public CommonManager(string name):base(name)
        { 
        
        }
        public override void RequestApploactions(Request request)
        {
           // throw new NotImplementedException();
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine("{0}:{1}数量{2}被批准",name,request.RequestContent,request.Number.ToString());
            }
            else if (Superior != null)
            {
                Superior.RequestApploactions(request);
            }
        }
    }
}
