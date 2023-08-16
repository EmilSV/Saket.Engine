﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Numerics;

namespace Saket.Engine
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public struct Transform
    {
        [FieldOffset(0)]
        public Vector3 Position;
        [FieldOffset(48)]
        public Quaternion Rotation;
        [FieldOffset(96)]
        public Vector3 Scale;
    }
}
