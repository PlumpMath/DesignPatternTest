using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.BaseCode
{
    public abstract class Commandexe
    {
        protected Receiver receiver = null;
        public Commandexe(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Excute();
    }
}
