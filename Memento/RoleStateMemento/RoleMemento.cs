using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.RoleStateMemento
{
    public class RoleMemento
    {
        private int vit;
        private int atk;
        private int def;

        public int Def
        {
            get { return def; }
            set { def = value; }
        }
        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }
        public int Vit
        {
            get { return vit; }
            set { vit = value; }
        }
        public  RoleMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
        
    }
}
