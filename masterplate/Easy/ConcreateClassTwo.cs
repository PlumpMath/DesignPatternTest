using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace masterplate.Easy
{
    public class ConcreateClassTwo:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            //throw new NotImplementedException();
            Console.WriteLine("西门登山");
        }

        public override void PrimitiveOperation2()
        {
           // throw new NotImplementedException();
            Console.WriteLine("下山东门出");
        }
    }
}
