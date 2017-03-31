using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Easy
{
    public class Adpter:Target
    {
        private Adptee adp = new Adptee();
        public override void Request()
        {
            adp.SpacificRequest();
        }
    }
}
