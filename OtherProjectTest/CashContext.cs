using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtherProjectTest
{
    public class CashContext
    {
        private CashSuper cs;
        public CashContext(string type)
        {

            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    this.cs = cs0;
                    break;
                case "满300返100":
                    CashReturn cs1 = new CashReturn("300","100");
                    this.cs=cs1;
                    break;
                case "打8折":
                    CashRebate cs2=new CashRebate("0.8");
                    this.cs=cs2;
                    break;
            }
        }
        public double ContextStrategy(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
