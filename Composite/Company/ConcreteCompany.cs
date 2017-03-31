using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Company
{
    public class ConcreteCompany:Company
    {
        private List<Company> childrent = new List<Company>();

        public ConcreteCompany(string name):base(name)
        { 
           
        }

        public override void Add(Company c)
        {
            //throw new NotImplementedException();
            childrent.Add(c);
        }

        public override void Remove(Company c)
        {
            //throw new NotImplementedException();
            childrent.Remove(c);
        }

        public override void Display(int depth)
        {
            //throw new NotImplementedException();
            Console.WriteLine(new String('-',depth)+name);
            foreach (Company item in childrent)
            {
                item.Display(depth+2);
            }
        }

        public override void LineOfDuty()
        {
            //throw new NotImplementedException();
            foreach (Company item in childrent)
            {
                item.LineOfDuty();
            }
        }
    }
}
