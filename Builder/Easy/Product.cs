using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Easy
{
    public class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }
        public void Show() 
        {
           Console.WriteLine("产品创建");
           foreach (string item in parts)
           {
               Console.WriteLine(item);
           }
        }
    }
}
