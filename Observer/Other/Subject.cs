using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Other
{
    public interface Subject
    {
        void Addach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string subjectstate{get;set;}
    }
}
