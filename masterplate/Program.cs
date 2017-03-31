using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using masterplate.Easy;

namespace masterplate
{
    class Program
    {
        public delegate void ConsoleWrite(string message);
        static void Main(string[] args)
        {
            //模版方法设计模式
            AbstractClass ac = null;
            ac =new Concreateone();
            ac.TemplateMethod();
            ac = new ConcreateClassTwo();
            ac.TemplateMethod();
           
            Console.Read();
            

        }
       
    }
}
