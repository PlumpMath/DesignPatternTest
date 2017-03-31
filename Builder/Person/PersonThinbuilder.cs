using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Builder.Person
{
    public class PersonThinbuilder:BuilderPersion
    {
        public PersonThinbuilder(Graphics g, Pen p):base(g,p)
        { 
        
        }

        public override void BuilderHead()
        {
            //throw new NotImplementedException();
            g.DrawEllipse(p,50, 20, 30, 30);
        }

        public override void BuilderBody()
        {
           // throw new NotImplementedException();
            g.DrawRectangle(p,60,50,10,50);
        }

        public override void BuilderArmLeft()
        {
            //throw new NotImplementedException();
            g.DrawLine(p, 60, 50, 40, 100);
        }

        public override void BuilderArmRight()
        {
           // throw new NotImplementedException();
            g.DrawLine(p, 70, 50, 90, 100);
        }

        public override void BuilderLegLeft()
        {
            //throw new NotImplementedException();
            g.DrawLine(p, 60, 100, 45, 150);
        }

        public override void BuilderLegRight()
        {
            //throw new NotImplementedException();
            g.DrawLine(p, 70, 100, 85, 150);
        }
    }
}
