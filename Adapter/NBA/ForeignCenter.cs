using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.NBA
{
    public class ForeignCenter
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Addaching()
        { 
           Console.WriteLine("外籍中锋 {0} 进攻",this.name);
        }
        public void Defenseing()
        {
            Console.WriteLine("外籍中锋 {0} 防守",this.name);
        }

    }
}
