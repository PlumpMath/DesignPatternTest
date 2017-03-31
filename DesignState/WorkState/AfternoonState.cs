using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class AfternoonState:WorkState
    {
        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            if (work.Hour < 17)
            {
                Console.WriteLine("当前时间:{0} .下午状态OK，加油！", work.Hour);
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}
