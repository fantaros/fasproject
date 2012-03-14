using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base
{
    public class lst : obj
    {
        internal static lst create(List<obj> val)
        {
            return new lst(val);
        }
        
        public lst()
        {
            this.__obj__ = string.Empty;
        }

        internal lst(List<obj> val)
        {
            this.__obj__ = val;
        }
    }
}
