using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Abstracts
{
    public abstract class APerson
    {
        public Guid Id
        {
            get;
        }

        public APerson()
        {
            Id = Guid.NewGuid();
        }
    }
}
