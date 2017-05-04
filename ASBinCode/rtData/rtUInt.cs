﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASBinCode.rtData
{
    public class rtUInt : RunTimeValueBase
    {
        
        public uint value;
        public rtUInt(uint v):base(RunTimeDataType.rt_uint)
        {
            value = v;
        }

        public sealed override  object Clone()
        {
            return new rtUInt(value);
        }

        public override string ToString()
        {
            return value.ToString();
        }

    }
}
