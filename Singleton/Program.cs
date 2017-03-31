using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sig = Singleton.Singleton;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式

            Sig.Singleton s1 = Sig.Singleton.GetInstance();
            Sig.Singleton s2 = Sig.Singleton.GetInstance();
            if(s1==s2)
            {
               Console.WriteLine("两个对象相等！");
            }
            Sig.SingleDotNet s3 = Sig.SingleDotNet.GetInstance();
            Sig.SingleDotNet s4 = Sig.SingleDotNet.GetInstance();
            if (s3 == s4)
            {
                Console.WriteLine("两个对象相等！");
            }
            Console.Read();
        }
    }
}
