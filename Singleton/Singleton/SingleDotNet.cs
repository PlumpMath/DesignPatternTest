using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton.Singleton
{
    public sealed class SingleDotNet
    {
        private static readonly SingleDotNet singledotnet = new SingleDotNet();
        private SingleDotNet() { }
        public static SingleDotNet GetInstance()
        {
            return singledotnet;
        }
    }
}
