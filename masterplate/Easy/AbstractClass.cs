using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace masterplate.Easy
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        private void Start()
        {
            Console.WriteLine("开始");
        }
        private void End()
        {
            Console.WriteLine("结束");
        }
        public void TemplateMethod()
        {
            Start();
            PrimitiveOperation1();
            PrimitiveOperation2();
            End();
            
        }
    }
}
