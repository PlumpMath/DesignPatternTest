using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //抽象工厂模式

            User user = new User();

            IFactory factory = new SqlserverFactory();
            Iuser ur=factory.CreateUser();

            ur.Inser(user);

            ur.GetUser("");

            factory = new AccessFactory();

            ur = factory.CreateUser();

            ur.Inser(user);

            ur.GetUser("");


            IDepartment dt = factory.CreateDepartment();
            dt.Insert(new Department() {Name="马化腾",ID="1234567" }); 
            dt.getDepartment("");


            ur = DataAccess.CreateUser();
            ur.Inser(new User() {Id="654789",Name="李彦宏"});
            ur.GetUser("");
            Console.Read();

        }
    }
}
