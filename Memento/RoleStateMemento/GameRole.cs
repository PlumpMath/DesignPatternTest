using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.RoleStateMemento
{
    public class GameRole
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

        public RoleMemento CreateRoleMemento()
        {
            return (new RoleMemento(vit,atk,def));
        }
        public void RecoveryRoleMemento(RoleMemento rolememento)
        {
            this.atk = rolememento.Atk;
            this.def = rolememento.Def;
            this.vit = rolememento.Vit;
        }
        public void InitState()
        {
            this.vit = 100;
            this.atk = 200;
            this.def = 300;
        }
        public void DisplayInfo()
        {            
            Console.WriteLine("角色状态:");
            Console.WriteLine("体力:{0}:",this.vit);
            Console.WriteLine("攻击力{0}:",this.atk);
            Console.WriteLine("防御力{0}:",this.def);
        }

        public void Over()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }
    }
}
