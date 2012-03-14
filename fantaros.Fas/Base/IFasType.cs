using System;
using System.Collections.Generic;
using System.Text;

namespace fantaros.Fas.Base
{
    public interface IFasType
    {
        bln isnil();
        bln isundefined();
        src source { get; set; }
        str type { get; }
        str tostr();
        obj exec(obj args);
        obj cast(str typename);
        bln equal(obj val);
        obj clone();
    }
}
