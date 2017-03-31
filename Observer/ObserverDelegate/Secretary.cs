using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public class Secretary:Subject
    {
        private string action;
        public event EventHandler Update;
        public void Notify()
        {
            //throw new NotImplementedException();
            Update();
        }

        public string subjectsate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
