using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Person
{
    
    public class Director
    {
        private BuilderPersion bp;
        public Director(BuilderPersion bp)
        {
            this.bp = bp;
        }
        public void CreatePerson()
        {
            if (this.bp == null)
            {
                return;
            }
            this.bp.BuilderHead();
            this.bp.BuilderBody();
            this.bp.BuilderArmLeft();
            this.bp.BuilderArmRight();
            this.bp.BuilderLegLeft();
            this.bp.BuilderLegRight();
        
        }
    }
}
