using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class NoonState:WorkState
    {

        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            if (work.Hour < 13)
            {
                Console.WriteLine("当前时间:{0} .饿了。犯困、午休",work.Hour);
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
