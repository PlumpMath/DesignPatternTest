using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFactory
{
    public abstract class Operation
    {
        private double numberone = 0;

        public double Numberone
        {
            get { return numberone; }
            set { numberone = value; }
        }
        private double numbertwo = 0;

        public double Numbertwo
        {
            get { return numbertwo; }
            set { numbertwo = value; }
        }
        public abstract double GetRestult();
    }
}
