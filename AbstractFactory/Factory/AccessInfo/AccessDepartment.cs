using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class AccessDepartment:IDepartment
    {

        public void Insert(Department dep)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Access添加一条部门记录");
        }

        public Department getDepartment(string id)
        {
           //throw new NotImplementedException();
            Console.WriteLine("Acces获取一条部门记录");
            return null;
        }
    }
}
