using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyWeight.WebSite
{
    public  class WebSiteFactory
    {
        private Hashtable flyweight = new Hashtable();

        public WebSiteClass getWebSiteCategory(string key)
        {
            if (!flyweight.ContainsKey(key))
            {
                flyweight.Add(key,new ConcreteWebSite(key));
            }
            return flyweight[key] as WebSiteClass;
        }

        public int GetWebSiteCount()
        {
            return flyweight.Count;
        }
    }
}
