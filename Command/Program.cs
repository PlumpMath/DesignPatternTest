using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.BaseCode;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //命令模式
            Receiver receiver = new Receiver();
            Commandexe cmd = new ConcreteCommand(receiver);
            Invoke invoke = new Invoke();
            invoke.SetCommand(cmd);
            invoke.ExecuteCommand();


            Console.Read();
        }
    }
}
