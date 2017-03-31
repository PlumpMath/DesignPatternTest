using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class SqlserverDepartment:IDepartment
    {

        public void Insert(Department dep)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sqlserver部门加入一条记录");
        }

        public Department getDepartment(string id)
        {
            Console.WriteLine("Sqlserver获取部门一条记录");
            //throw new NotImplementedException();
            return null;
        }
    }
}
