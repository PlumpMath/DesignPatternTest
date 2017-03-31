using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototype.EasyPrototype;
using Prototype.OtherPrototype;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //原型模式
            ConcreatePrototype1 proto = new ConcreatePrototype1("你好");
            ConcreatePrototype1 proto1 = proto.Clone() as ConcreatePrototype1;
            Console.WriteLine("原有对象{0},复制的对象{1}",proto.Id,proto1.Id);

            Resume re = new Resume("李伟波");
            re.setPersonalInfo("24", "男");
            re.setWorkExperience("2016-05-01","腾讯科技");
            
            Resume re1=re.Clone() as Resume;
            re1.setWorkExperience("2016-05-01", "阿里巴巴");
            re.Display();
            re1.Display();


            Resumeone re2 = new Resumeone("刘明");
            re2.setPersonalInfo("24", "男");
            re2.setWorkExperience("2016-05-01", "腾讯科技");

            Resumeone re3 = re2.Clone() as Resumeone;
            re3.setWorkExperience("2016-05-01", "阿里巴巴");
            re2.Display();
            re3.Display();
            Console.Read();

        }
    }
}
