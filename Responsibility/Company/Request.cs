using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Responsibility.Company
{
    public class Request
    {
        public string RequestType
        { get; set; }
        public string RequestContent { get; set; }
        public int Number { get; set; }
    }
}
