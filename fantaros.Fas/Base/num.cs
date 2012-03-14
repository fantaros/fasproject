using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base
{
    public class num : obj
    {
        internal static num create(double val)
        {
            return new num(val);
        }
        
        public num() 
        {
            this.__obj__ = 0;
        }

        internal num(double val) 
        {
            this.__obj__ = val;
        }
    }
}
