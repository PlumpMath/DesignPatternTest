using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class SqlserverFactory:IFactory
    {

        public Iuser CreateUser()
        {
            //throw new NotImplementedException();
            return new SqlserverUser();
        }


        public IDepartment CreateDepartment()
        {
           // throw new NotImplementedException();
            return new SqlserverDepartment();
        }
    }
}
