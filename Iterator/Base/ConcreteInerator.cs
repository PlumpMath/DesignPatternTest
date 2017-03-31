using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Base
{
    public class ConcreteInerator : Iterator
    {
        private ConcreateAggregate aggregate;
        private int current=0;

        public ConcreteInerator(ConcreateAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object First()
        {
            //throw new NotImplementedException();
            return aggregate[0];
        }

        public override object Next()
        {
            //throw new NotImplementedException();
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            //throw new NotImplementedException();
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
           // throw new NotImplementedException();
            return aggregate[current];
        }
    }
}
