using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Person
{
    public class BigTrouser:Finery
    {
        public override void Show()
        {
            Console.WriteLine("裤子");
            base.Show();
        }
    }
}
