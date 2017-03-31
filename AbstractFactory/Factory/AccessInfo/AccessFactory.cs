using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class AccessFactory:IFactory
    {

        public Iuser CreateUser()
        {
            //throw new NotImplementedException();
            return new AccessUser();
        }


        public IDepartment CreateDepartment()
        {
            //throw new NotImplementedException();
            return new AccessDepartment();
        }
    }
}
