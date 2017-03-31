using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Easy
{
    public abstract class Subject
    {
        private IList<Observer> observer = new List<Observer>();
        public void Aattach(Observer observer)
        {
            this.observer.Add(observer);
        }
        public void Detach(Observer observer)
        { 
           this.observer.Remove(observer);
        }
        public void Notify()
        {
            foreach (Observer item in observer)
            {
                item.Update();
            }
        }

    }
}
