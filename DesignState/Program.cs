using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignState.Easy;

namespace DesignState
{
    class Program
    {
        static void Main(string[] args)
        {
            //状态模式 

            Context context = new Context(new ConcteteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();


            WorkState.Work work = new WorkState.Work();
            work.Hour = 9;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 16;
            work.WriteProgram();
            work.Hour = 17;
            work.Finish = false;
            work.WriteProgram();
            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 21;
            work.WriteProgram();


            Console.Read();
        }
    }
}
