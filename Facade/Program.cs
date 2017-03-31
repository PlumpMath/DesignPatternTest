using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //外观模式
            Facade facede = new Facade();
            facede.DefaultMethodA();
            facede.DefaultMethodB();
            Console.Read();
        }
    }
}
