using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Easy
{
    public abstract class Builder
    {

        public abstract void BuilderA();
        public abstract void BuilderB();
        public abstract Product GetResult();
    }
}
