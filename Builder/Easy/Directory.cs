using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Easy
{
    public class Directory
    {
        public void ConStract(Builder bd)
        {
            bd.BuilderA();
            bd.BuilderB();
            Console.Read();
        }
    }
}
