using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory
{
    public class MuIFactory:IFactory
    {

        public Operation getOperation()
        {
            //throw new NotImplementedException();
            return new Mul();
        }
    }
}
