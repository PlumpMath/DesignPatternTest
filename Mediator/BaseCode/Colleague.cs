﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.BaseCode
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }


    }
}
