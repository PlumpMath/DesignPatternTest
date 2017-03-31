using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory
{
    public class SubFactory : IFactory
    {
        public  Operation getOperation()
        {

            return new Sub();
        }
    }
}
