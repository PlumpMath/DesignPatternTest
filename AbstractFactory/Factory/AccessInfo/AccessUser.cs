using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public class AccessUser:Iuser
    {

        public void Inser(User user)
        {
            //throw new NotImplementedException();
            Console.WriteLine("在Access中添加一条记录.ID:{0} Name:{1}", user.Id, user.Name);
        }

        public User GetUser(string id)
        {
            //throw new NotImplementedException();
            Console.WriteLine("获取Access中一条记录");
            return null;
        }
    }
}
