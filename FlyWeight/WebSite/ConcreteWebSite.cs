using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeight.WebSite
{
    public class ConcreteWebSite:WebSiteClass
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }
        public override void Use(User user)
        {
            //throw new NotImplementedException();
            Console.WriteLine("网站分类:{0}\t用户:{1}",name,user.Name);
        }
    }
}
