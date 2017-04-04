using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Music
{
    public abstract class MusicExpression
    {
        public void Interpret(PlayContext context)
        {
            if (context.Playtext.Length == 0)
            {
                return;
            }
            else
            {
                string playKey = context.Playtext.Substring(0,1);
                context.Playtext = context.Playtext.Substring(2);
                double playValue = Convert.ToDouble(context.Playtext.Substring(0,context.Playtext.IndexOf(" ")));
                context.Playtext = context.Playtext.Substring(context.Playtext.IndexOf(" ")+1);
                Excute(playKey,playValue);

            }
        }
        public abstract void Excute(string key,double value);

    }
}
