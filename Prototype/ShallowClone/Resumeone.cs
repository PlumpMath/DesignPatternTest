using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototype.ShallowClone;

namespace Prototype.OtherPrototype
{
    public class Resumeone:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resumeone(string name)
        {
            this.name = name;
            this.work = new WorkExperience();
        }
        public void setPersonalInfo(string age,string sex)
        {
            this.age = age;
            this.sex = sex;
        }
        public void setWorkExperience(string time,string company)
        {
            this.work.Time = time;
            this.work.Company = company;
           
        }
        public void Display()
        {
            Console.WriteLine(string.Format("{0} {1} {2}", this.name, this.age, this.sex));
            Console.WriteLine(string.Format("{0} {1}", this.work.Company, this.work.Time));
        }
        public object Clone()
        {
            //throw new NotImplementedException();
            Resumeone rd = this.MemberwiseClone() as Resumeone;
            rd.work = this.work.Clone() as WorkExperience;
            return rd;
        }
    }
}
