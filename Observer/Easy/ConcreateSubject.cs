using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Easy
{
    public  class ConcreateSubject:Subject
    {
        private string subjectstate;

        public string Subjectstate
        {
            get { return subjectstate; }
            set { subjectstate = value; }
        }

    }
}
