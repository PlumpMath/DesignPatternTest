using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Other
{
    public class Boss:Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;
        public void Addach(Observer observer)
        {
            //throw new NotImplementedException();
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            //throw new NotImplementedException();
            observers.Remove(observer);
        }

        public void Notify()
        {
            //throw new NotImplementedException();
            foreach (Observer item in observers)
            {
                item.Update();
            }
        }

        public string subjectstate
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
    }
}
