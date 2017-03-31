using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class SleepingState:WorkState
    {

        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            Console.WriteLine("当前时间:{0} 顶不住了，睡觉了！",work.Hour);
        }
    }
}
