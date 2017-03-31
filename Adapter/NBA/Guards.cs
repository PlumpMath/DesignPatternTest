using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.NBA
{
    public class Guards:Player
    {
        public Guards(string name)
            : base(name)
        { 
        
        }

        public override void Addach()
        {
            //throw new NotImplementedException();
            Console.WriteLine("后卫{0} 进攻",this.name);
        }

        public override void Defense()
        {
            //throw new NotImplementedException();
            Console.WriteLine("后卫{0} 防守", this.name);
        }
    }
}
