using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Mobile
{
    public abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();

    }
}
