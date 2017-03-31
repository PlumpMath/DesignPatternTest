using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Base
{
    public class ConcreteIneratorDesc : Iterator
    {
        private ConcreateAggregate aggregate;
        private int current=0;

        public ConcreteIneratorDesc(ConcreateAggregate aggregate)
        {
            this.aggregate = aggregate;
            this.current = aggregate.Count - 1;
        }
        public override object First()
        {
            //throw new NotImplementedException();
            return aggregate[aggregate.Count-1];
        }

        public override object Next()
        {
            //throw new NotImplementedException();
            object ret = null;
            current--;
            if (current>=0)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            //throw new NotImplementedException();
            return current <0 ? true : false;
        }

        public override object CurrentItem()
        {
           // throw new NotImplementedException();
            return aggregate[current];
        }
    }
}
