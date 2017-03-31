using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memento.Easy;
using Memento.RoleStateMemento;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //备忘录
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();

            o.SetMement(c.Memento);
            o.Show();



            GameRole gr = new GameRole();
            gr.InitState();
            gr.DisplayInfo();
            RoleCaretaker roletaker = new RoleCaretaker();
            roletaker.Rolememento=gr.CreateRoleMemento();

            gr.Over();
            gr.DisplayInfo();

            gr.RecoveryRoleMemento(roletaker.Rolememento);
            gr.DisplayInfo();


            Console.Read();


        }
    }
}
