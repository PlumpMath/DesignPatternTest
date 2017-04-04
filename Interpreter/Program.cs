using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpreter.BaseCode;
using Interpreter.Music;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {

            //解释器模式
            Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NotTerminalExpression());
            list.Add(new NotTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression item in list)
            {
                item.Interpret(context);
            }
            Console.WriteLine("*************************************\n\n");


            PlayContext context1 = new PlayContext();
            Console.WriteLine("上海滩:");

            context1.Playtext = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3";
            MusicExpression expression = null;

            try
            {
                while(context1.Playtext.Length>0)
                {
                    string str = context1.Playtext.Substring(0,1);

                    switch(str)
                    {
                        case "O":
                            expression = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;
                    
                    }
                    //if (expression != null)
                    {
                        expression.Interpret(context1);
                    }
                
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }
}
