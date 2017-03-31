using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.ObserverDelegate
{
    public interface Subject
    {
        void Notify();
        string subjectsate { get; set; }
    }
}
