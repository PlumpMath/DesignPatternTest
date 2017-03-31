using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public interface IFactory
    {
        Iuser CreateUser();
        IDepartment CreateDepartment();
    }
}
