using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Easy
{
    public class Composites:Component
    {
        private List<Component> children = new List<Component>();

        public Composites(string name):base(name)
        { 
        
        }
        public override void Add(Component c)
        {
            //throw new NotImplementedException();
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            //throw new NotImplementedException();
            children.Remove(c);
        }

        public override void Display(int depth)
        {
           // throw new NotImplementedException();
            Console.WriteLine(new String('-', depth) + name);
            foreach (Component item in children)
            {
                item.Display(depth+2);
            }
        }
    }
}
