using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory
{
    public class DivFactory:IFactory
    {

        public Operation getOperation()
        {
            //throw new NotImplementedException();
            return new Div();
        }
    }
}
