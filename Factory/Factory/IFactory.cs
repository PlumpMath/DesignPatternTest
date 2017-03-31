using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory
{
    public interface IFactory
    {
        Operation getOperation();
    }
}
