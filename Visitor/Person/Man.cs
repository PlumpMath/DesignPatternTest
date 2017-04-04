using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Person
{
    public class Man:Person
    {
        public override void Accept(Aaction visitor)
        {
            //throw new NotImplementedException();
            visitor.GetManConclusion(this);
        }
    }
}
