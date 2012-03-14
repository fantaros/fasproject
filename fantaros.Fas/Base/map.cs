using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base
{
    public class map : obj
    {
        internal static map create(Dictionary<str, obj> val)
        {
            return new map(val);
        }
        
        public map()
        {
            this.__obj__ = new Dictionary<str, obj>();
        }

        internal map(Dictionary<str, obj> val)
        {
            this.__obj__ = val;
        }
    }
}
