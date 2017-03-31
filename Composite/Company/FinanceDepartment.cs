using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Company
{
    public class FinanceDepartment:Company
    {
        public FinanceDepartment(string name)
            : base(name)
        { }
        public override void Add(Company c)
        {
            //throw new NotImplementedException();
        }

        public override void Remove(Company c)
        {
           // throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            //throw new NotImplementedException();
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}公司财务收支管理。", name);
        }
    }
}
