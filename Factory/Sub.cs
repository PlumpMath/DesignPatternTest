using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class Sub:Operation
    {
        public override double GetRestult()
        {
            //throw new NotImplementedException();
            return this.Numberone - this.Numbertwo;
        }
    }
}
