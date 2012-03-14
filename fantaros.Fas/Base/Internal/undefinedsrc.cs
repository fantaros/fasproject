using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fantaros.Fas.Base.Internal
{
    public class undefinedsrc : obj
    {
        public readonly static obj undefined = new undefinedsrc();

        public override bln isnil()
        {
            return bln.create(true);
        }

        public override bln isundefined()
        {
            return bln.create(true);
        }

        public override obj cast(str typename)
        {
            return undefinedsrc.undefined;
        }
    }
}
