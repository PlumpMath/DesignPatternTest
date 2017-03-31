using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Factory
{
    public interface Iuser
    {
        void Inser(User user);
        User GetUser(string id);
    }
}
