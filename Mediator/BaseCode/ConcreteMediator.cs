using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.BaseCode
{
    public class ConcreteMediator:Mediator
    {
        private ConcreteColleague1 concretecolleague1;
        private ConcreteColleague2 concretecolleague2;

        public ConcreteColleague1 Concretecolleague1
        {
            //get { return concretecolleague1; }
            set { concretecolleague1 = value; }
        }
        public ConcreteColleague2 Concretecolleague2
        {
            //get { return concretecolleague2; }
            set { concretecolleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            //throw new NotImplementedException();
            if (colleague == concretecolleague1)
            {
                concretecolleague2.Notify(message);
            }
            else
            {
                concretecolleague1.Notify(message);
            }
        }
    }
}
