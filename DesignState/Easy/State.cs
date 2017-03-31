using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.Easy
{
    public abstract class State
    {
        public abstract void Handler(Context  context);
    }
}
