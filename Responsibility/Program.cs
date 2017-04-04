using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Responsibility.BaseCode;
using Responsibility.Company;

namespace Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //职责链模式

            Handler handler1 = new ConcreteHandler1();
            Handler handler2= new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();
            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);

            int[] request = {2,6,10,15,18,20,28,29,8,5,4 };

            foreach (int item in request)
            {
                handler1.HandleRequest(item);   
            }
            Console.WriteLine("*****************************************");



            CommonManager jingli = new CommonManager("金立");
            Majordomo zongjian = new Majordomo("张无忌");
            GeneraManager zongjingli = new GeneraManager("张三丰");

            jingli.SetSuperior(zongjian);
            zongjian.SetSuperior(zongjingli);

            jingli.RequestApploactions(new Request {Number=1,RequestType="请假",RequestContent="请假一天" });
            jingli.RequestApploactions(new Request { Number = 10, RequestType = "请假", RequestContent = "请假一天" });

            jingli.RequestApploactions(new Request { Number = 500, RequestType = "加薪", RequestContent = "请求加薪" });

            jingli.RequestApploactions(new Request { Number = 1000, RequestType = "加薪", RequestContent = "请求加薪" });

            Console.Read();
 
        }
    }
}
