using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public interface IDepartment
    {
        void Insert(Department dep);
        Department getDepartment(string id);
    }
}
