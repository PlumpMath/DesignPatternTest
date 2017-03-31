using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtherProjectTest
{
   public  class CashReturn:CashSuper
   {
       private double moneyCondition = 0.0d;
       private double moneyReturn = 0.0d;
       public CashReturn(string moneyCondition,string moneyReturn)
       {
           this.moneyCondition = double.Parse(moneyCondition);
           this.moneyReturn = double.Parse(moneyReturn);
       }

       public override double acceptCash(double money)
       {
           //throw new NotImplementedException();
           double returnmoney = money;
           if (money >= this.moneyCondition)
           { 
              returnmoney=money-Math.Floor(money/moneyCondition)*moneyReturn;
           }
           return returnmoney;
       }

   }
}
