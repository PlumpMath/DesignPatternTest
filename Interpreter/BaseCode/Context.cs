using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.BaseCode
{
    public class Context
    {
        private string input;
        private string output;

        public string Output
        {
            get { return output; }
            set { output = value; }
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }
    }
}
