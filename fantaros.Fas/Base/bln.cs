using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base
{
    public class bln : obj
    {
        internal static bln create(bool val)
        {
            return new bln(val);
        }
        
        public bln() 
        {
            __obj__ = false;
        }
        
        internal bln(bool val)
        {
            __obj__ = val;
        }
    }
}
