using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyFactory
{
    public class Factory
    {
        public static Operation getOperation(string operation)
        {
            Operation returnObject = null;
            switch(operation)
            {
                case "+":
                    returnObject = new Add();
                    break;
                case "-":
                    returnObject = new Sub();
                    break;
                case "*":
                    returnObject = new Mul();
                    break;
                case "/":
                    returnObject = new Div();
                    break;
            
            }
            return returnObject;
        }
    }
}
