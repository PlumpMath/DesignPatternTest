using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.BaseCode
{
    public class ConcreteCommand:Commandexe
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {
          
        }
        public override void Excute()
        {
           //throw new NotImplementedException();
            receiver.Action();
           
        }
    }
}
