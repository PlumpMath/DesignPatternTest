using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.EasyPrototype
{
    public class ConcreatePrototype1:Prototype
    {
        public ConcreatePrototype1(string id):base(id)
        { 
        
        }

        public override Prototype Clone()
        {
            //throw new NotImplementedException();
            return this.MemberwiseClone() as Prototype;
        }
    }
}
