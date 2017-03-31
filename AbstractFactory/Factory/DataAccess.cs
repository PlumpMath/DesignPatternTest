using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AbstractFactory.Factory
{
    public class DataAccess
    {
        private static readonly string assemblyName = "AbstractFactory";
        private static readonly string db = "Sqlserver";
        public static Iuser CreateUser()
        {
            string className = assemblyName + ".Factory." + db + "User";
            return (Iuser)Assembly.Load(assemblyName).CreateInstance(className);
        }
        public static IDepartment CreateDepartment()
        {

            string className = assemblyName + ".Factory." + db + "Department";
           return (IDepartment)Assembly.Load(assemblyName).CreateInstance(className);
        }

    }
}
