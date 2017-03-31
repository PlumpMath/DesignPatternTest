using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Easy
{
    public  class ConcreateObserver:Observer
    {
        private string name;
        private string observerstate;
        private ConcreateSubject subject;

        public ConcreateSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public ConcreateObserver(ConcreateSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }


        public override void Update()
        {
            //throw new NotImplementedException();
            observerstate = subject.Subjectstate;
            Console.WriteLine("观察者{0}的新状态是{1}",name,observerstate);
        }

}
}
