using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Abstracts
{
    public abstract class AModel
    {
        public Guid Id
        {
            get;
        }

        public AModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
