using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.ShallowClone
{
    public class WorkExperience:ICloneable
    {
        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            return this.MemberwiseClone();
        }
    }
}
