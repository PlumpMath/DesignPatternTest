using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite.Easy;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //组合模式

            Composites root = new Composites("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));


            Composites comp = new Composites("Composites X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);


            Composites comp2 = new Composites("Composites Xy");
            comp2.Add(new Leaf("Leaf XyA"));
            comp2.Add(new Leaf("Leaf XyB"));

            comp.Add(comp2);


            root.Add(new Leaf("Leaf C"));

            Leaf lefaf = new Leaf("Leaf D");
            root.Add(lefaf);
            root.Remove(lefaf);

            root.Display(1);




            Company.ConcreteCompany roots = new Company.ConcreteCompany("北京总公司");

            roots.Add(new Company.HRDepartment("总公司人力资源"));
            roots.Add(new Company.FinanceDepartment("总公司财务管理"));


            Company.ConcreteCompany company = new Company.ConcreteCompany("上海华东分公司");

            company.Add(new Company.HRDepartment("华东公司人力资源"));
            company.Add(new Company.FinanceDepartment("华东公司财务管理"));
            roots.Add(company);

            roots.Display(1);

            roots.LineOfDuty();

            Console.Read();


        }
    }
}
