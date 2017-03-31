using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Easy
{
    class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public Memento CreateMemento()
        { 
          return (new Memento(state));
        }
        public void SetMement(Memento memento)
        {
            state = memento.State;
        }
        public void Show()
        {
            Console.WriteLine("State={0}",this.state);
        }
    }
}
