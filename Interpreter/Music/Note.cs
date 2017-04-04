using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Music
{
    public class Note:MusicExpression
    {

        public override void Excute(string key, double value)
        {
           // throw new NotImplementedException();
            string note = "";
            switch (key)
            { 
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
              

            }
            Console.WriteLine(note);
        }
    }
}
