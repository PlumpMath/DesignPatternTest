using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Easy;

namespace Observer
{
    class Program
    {  
        static void Main(string[] args)
        {
            //观察者模式

            ConcreateSubject subject = new ConcreateSubject();
            subject.Aattach(new ConcreateObserver(subject, "A"));
            subject.Aattach(new ConcreateObserver(subject, "B"));
            subject.Aattach(new ConcreateObserver(subject, "C"));
            subject.Aattach(new ConcreateObserver(subject, "D"));
            subject.Subjectstate = "xyz";
            subject.Notify();


            Other.Boss boss = new Other.Boss();
            Other.StackObserver stackobs = new Other.StackObserver("刘德华",boss);

            boss.Addach(stackobs);
            boss.subjectstate = "老板回来了";
            boss.Notify();



            ObserverDelegate.Boss bos = new ObserverDelegate.Boss();

            ObserverDelegate.StackObserver stack = new ObserverDelegate.StackObserver("刘德华",bos);
            ObserverDelegate.NBAStackObserver nba = new ObserverDelegate.NBAStackObserver("张学友",bos);
            bos.Update+=new ObserverDelegate.EventHandler(stack.CloseStackMarket);
            bos.Update += new ObserverDelegate.EventHandler(nba.CloseNBADirectseeding);
            bos.subjectsate = "老板来了";
            bos.Notify();

            Console.Read();

        }
    }
}
