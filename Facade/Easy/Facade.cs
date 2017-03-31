using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    
    public  class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }
        public void DefaultMethodA() 
        {
            Console.WriteLine("方法组A");
            one.defaultMethodOne();
            three.defaultMethodmThree();
            four.defaultMethodmFour();
        }
        public void DefaultMethodB()
        {
            Console.WriteLine("方法组B");
            two.defaultMethodmTwo();
        }
        
    }
}
