using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Person
{
    public class TShirts:Finery
    {
        public override void Show()
        {
            Console.WriteLine("T桖");
            base.Show();
        }
    }
}
