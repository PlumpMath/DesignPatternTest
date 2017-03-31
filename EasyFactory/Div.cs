using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFactory
{
    public class Div:Operation
    {
        public override double GetRestult()
        {
            //throw new NotImplementedException();
            if (this.Numbertwo ==0)
            {
                throw new ArgumentOutOfRangeException("除数不能为0");
            }
            return this.Numberone / this.Numbertwo;
            
             
        }
    }
}
