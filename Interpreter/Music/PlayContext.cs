using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Music
{
    public class PlayContext
    {
        private string context;

        public string Playtext
        {
            get { return context; }
            set { context = value; }
        }
    }
}
