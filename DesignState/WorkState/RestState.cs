using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignState.WorkState
{
    public class RestState:WorkState
    {
        public override void WriteProgram(Work work)
        {
            //throw new NotImplementedException();
            Console.WriteLine("当前时间:{0} 下班回家了！", work.Hour);
        }
    }
}
