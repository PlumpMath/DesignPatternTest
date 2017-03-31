using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public class Boss:Subject
    {
        public event EventHandler Update;
        private string action;
        public void Notify()
        {
            //throw new NotImplementedException();
            Update();
        }

        public string subjectsate
        {
            get
            {
                return action;
                //throw new NotImplementedException();
            }
            set
            {
                //throw new NotImplementedException();
                action = value;
            }
        }
    }
}
