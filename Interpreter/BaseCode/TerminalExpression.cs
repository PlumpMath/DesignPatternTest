using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.BaseCode
{
    public class TerminalExpression:AbstractExpression
    {

        public override void Interpret(Context context)
        {
           // throw new NotImplementedException();
            Console.WriteLine("终端解释器");
        }
    }
}
