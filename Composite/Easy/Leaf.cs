using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Easy
{
    public class Leaf:Component
    {
        public Leaf(string name):base(name)
        { 
        
        }
        public override void Add(Component c)
        {
            //throw new NotImplementedException();
            Console.WriteLine("");
        }

        public override void Remove(Component c)
        {
            //throw new NotImplementedException();
            Console.WriteLine("");
        }

        public override void Display(int depth)
        {
            //throw new NotImplementedException();
            Console.WriteLine(new String('-',depth)+name);
        }
    }
}
