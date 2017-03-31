using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.Easy
{
    public class Context
    {
        private State sate;

        public State Sate
        {
            get { return sate; }
            set { sate = value; Console.WriteLine("当前状态:{0}",sate.GetType().Name); }
        }
        public Context(State state)
        {
            this.sate = state;
        }
        public void Request()
        {
            this.sate.Handler(this);
        }
    }
}
