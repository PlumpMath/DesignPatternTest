using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class EveningState:WorkState
    {

        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            if (work.Finish)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine("当前时间:{0} .在加班！累死了！", work.Hour);
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
