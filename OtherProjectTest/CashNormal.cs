using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtherProjectTest
{
    public class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            //throw new NotImplementedException();
            return money;
        }
    }
}
