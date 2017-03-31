using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.NBA
{
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }
        public abstract void Addach();
        public abstract void Defense();
    }
}
