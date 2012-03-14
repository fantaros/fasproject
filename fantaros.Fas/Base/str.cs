using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base
{
    public class str : obj
    {
        public static str empty = str.create(string.Empty);
        public static str sstr = str.create("str");
        public static str sobj = str.create("obj");
        public static str slst = str.create("lst");
        public static str smap = str.create("map");
        public static str snum = str.create("num");
        public static str ssrc = str.create("$");

        internal static str create(string val)
        {
            return new str(val);
        }
        
        public str() 
        {
            this.__obj__ = string.Empty;
        }

        internal str(string val) 
        {
            this.__obj__ = val;
        }

        public override str type
        {
            get
            {
                return str.create("str");
            }
        }
    }
}
