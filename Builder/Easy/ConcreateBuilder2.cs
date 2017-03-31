using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Easy
{
    public class ConcreateBuilder2:Builder
    {
        private Product product = new Product();


        public override void BuilderA()
        {
            //throw new NotImplementedException();
            product.Add("产品B1");
        }

        public override void BuilderB()
        {
            //throw new NotImplementedException();
            product.Add("产品B2");
        }

        public override Product GetResult()
        {
            //throw new NotImplementedException();
            return product;
        }
    }
}
