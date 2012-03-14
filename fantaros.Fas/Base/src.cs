using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fantaros.Fas.Parser;

namespace fantaros.Fas.Base
{
    public class src : obj
    {
        internal string __src__;
        internal FasParser __pas__;

        public src()
        {
            __src__ = string.Empty;    
        }

        public src(string source)
        {
            __src__ = source;
        }
        
    }
}
