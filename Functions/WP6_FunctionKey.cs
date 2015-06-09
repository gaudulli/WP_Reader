using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Reader
{    
    class WP6_FunctionKey {
        public byte group;
        public byte subgroup;

        public WP6_FunctionKey(byte group, byte subgroup) {
            this.group = group;
            this.subgroup = subgroup;

        }

        public override int GetHashCode()
        {
            return group.GetHashCode() + subgroup.GetHashCode();
        }

        public override bool Equals(object obj) {

            if (obj.GetType() == this.GetType()) {
                WP6_FunctionKey func = (WP6_FunctionKey)obj;

                if (func.group.Equals(this.group) && func.subgroup.Equals(this.subgroup)) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}
