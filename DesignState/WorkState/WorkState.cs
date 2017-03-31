using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public abstract class WorkState
    {
        public abstract void WriteProgram(Work work);
    }
}
