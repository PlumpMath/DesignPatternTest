using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Music
{
    public class Scale:MusicExpression
    {
        public override void Excute(string key, double value)
        {
           // throw new NotImplementedException();
            string scale = "";
            switch(Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;

            }
            Console.WriteLine(scale);
        }
    }
}
