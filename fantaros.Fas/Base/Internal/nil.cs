using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base.Internal
{
    public class nilsrc : obj
    {
        public readonly static obj nil = new nilsrc();

        public override bln isnil()
        {
            return bln.create(true);
        }

        public override bln isundefined()
        {
            return bln.create(false);
        }

        public override obj cast(str typename)
        {
            return nilsrc.nil;
        }
    }
}
