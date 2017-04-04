using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FlyWeight.BaseCode
{
    public class FlyWeightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyWeightFactory()
        {
            flyweights.Add("x",new ConcreteFlyweight());
            flyweights.Add("y", new ConcreteFlyweight());
            flyweights.Add("z", new ConcreteFlyweight());

        }
        public Flyweight GetFlayWeight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
}
