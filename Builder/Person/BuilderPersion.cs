using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Builder.Person
{
    public abstract class BuilderPersion
    {
      protected  Graphics g = null;
      protected Pen p = null;
      public BuilderPersion(Graphics g,Pen p)
      {
          this.g = g;
          this.p = p;
      }
      public abstract void BuilderHead();
      public abstract void BuilderBody();
      public abstract void BuilderArmLeft();
      public abstract void BuilderArmRight();
      public abstract void BuilderLegLeft();
      public abstract void BuilderLegRight();
    }
}
