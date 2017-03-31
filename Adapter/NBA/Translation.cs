using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.NBA
{
    public  class Translation:Player
    {
        ForeignCenter foreigncenter = new ForeignCenter();
        public  Translation(string name):base(name)
        {
            foreigncenter.Name = name;
        }
        public override void Addach()
        {
            //throw new NotImplementedException();
            foreigncenter.Addaching();
        }

        public override void Defense()
        {
           // throw new NotImplementedException();
            foreigncenter.Defenseing();
        }
    }
}
