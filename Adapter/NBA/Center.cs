using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.NBA
{
    public class Center : Player
    {
        public Center(string name)
            : base(name)
        { 
        
        }

        public override void Addach()
        {
            //throw new NotImplementedException();
            Console.WriteLine("中锋{0} 进攻",this.name);
        }

        public override void Defense()
        {
            //throw new NotImplementedException();
            Console.WriteLine("中锋{0} 防守", this.name);
        }
    }
}
