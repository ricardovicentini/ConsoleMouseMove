using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace User32Dll
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2
    {
        public struct Axis
        {
            public int Horizontal { get; set; }
            public int Vertical { get; set; }
            public Axis(int x, int y)
            {
                Horizontal = x;
                Vertical = y;
            }
        }
    }
}
