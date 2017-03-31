using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Base
{
    public class ConcreateAggregate:Aggregate
    {
        private IList<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
           // throw new NotImplementedException();
            return new ConcreteInerator(this);
        }
        public int Count
        {
            get {return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index,value); }
        }
    }
}
