using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.BaseCode
{
    public class Invoke
    {
        private Commandexe command;

        public void SetCommand(Commandexe command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Excute();
        }
    }
}
