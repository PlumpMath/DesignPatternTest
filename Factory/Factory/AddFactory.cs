using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory
{
    public class AddFactory : IFactory
    {
        public Operation getOperation()
        {

            return new Add();
        }
    }
}
