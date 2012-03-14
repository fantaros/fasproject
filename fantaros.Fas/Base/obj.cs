using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fantaros.Fas.Base.Internal;

namespace fantaros.Fas.Base
{
    public class obj : IFasType
    {
        internal object __obj__;
        internal src __ctr__;
        
        public virtual bln isnil()
        {
            return this.equal(nilsrc.nil);
        }

        public virtual bln isundefined()
        {
            return this.equal(undefinedsrc.undefined);
        }

        public virtual src source
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual str type
        {
            get
            {
                return str.sobj;
            }
        }

        public virtual str tostr()
        {
            throw new NotImplementedException();
        }

        public virtual obj exec(obj args)
        {
            throw new NotImplementedException();
        }

        public virtual obj cast(str typename)
        {
            switch (typename.__obj__.ToString())
            {

                default:
                    return nilsrc.nil;
            }
        }

        public virtual bln equal(obj val)
        {
            if (this.type == val.type) 
            {
                if (this.__obj__ == val.__obj__)
                    return bln.create(true);
                else
                    return bln.create(false);
            }
            return bln.create(false);
        }
        
        public obj clone()
        {
            throw new NotImplementedException();
        }
    }
}
