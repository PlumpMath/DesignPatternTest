using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class Work
    {
        private WorkState current;
        private double hour;
        private bool finish = false;

        public bool Finish
        {
            get { return finish; }
            set { finish = value; }
        }

        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public Work()
        {
            current = new ForenoonState();
        }
        public void SetState(WorkState ws)
        {
            current = ws;
        }
        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
