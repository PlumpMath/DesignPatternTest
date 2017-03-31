using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.OtherPrototype
{
    public class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string time;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }
        public void setPersonalInfo(string age,string sex)
        {
            this.age = age;
            this.sex = sex;
        }
        public void setWorkExperience(string time,string company)
        {
            this.time = time;
            this.company = company;
           
        }
        public void Display()
        {
            Console.WriteLine(string.Format("{0} {1} {2}", this.name, this.age, this.sex));
            Console.WriteLine(string.Format("{0} {1}", this.company,this.time));
        }
        public object Clone()
        {
            //throw new NotImplementedException();
            return this.MemberwiseClone();
        }
    }
}
