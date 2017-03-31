using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Mobile
{
    public class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            //throw new NotImplementedException();
            Console.WriteLine("我是手机品牌N");
            soft.Run();
        }
    }
}
