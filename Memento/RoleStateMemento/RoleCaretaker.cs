using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.RoleStateMemento
{
    class RoleCaretaker
    {
        private RoleMemento rolememento;


        public RoleMemento Rolememento
        {
            get { return rolememento; }
            set { rolememento = value; }
        }

    }
}
