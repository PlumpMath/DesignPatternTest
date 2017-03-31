using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class ForenoonState:WorkState
    {
        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            if (work.Hour < 12)
            {
                Console.WriteLine("当前时间:{0} .上午工作精神百倍", work.Hour);
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
