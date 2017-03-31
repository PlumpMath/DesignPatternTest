using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Company
{
    public class HRDepartment:Company
    {
        public HRDepartment(string name)
            : base(name)
        { }
        public override void Add(Company c)
        {
            //throw new NotImplementedException();
        }

        public override void Remove(Company c)
        {
            //throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
           // throw new NotImplementedException();
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            //throw new NotImplementedException();
            Console.WriteLine("{0}员工招聘培训管理。",name);
        }
    }
}
