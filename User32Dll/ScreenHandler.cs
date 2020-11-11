using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace User32Dll
{
    

    public static class ScreenHandler
    {
        
        public enum ScreenAnchor
        { 
            UpperLeft,
            UpperMiddle,
            UpperRight,
            BottonLeft,
            BottonMiddle,
            BottonRight,
            CenterLeft,
            CenterMiddle,
            CenterRight


        }
    
        

        [DllImport("User32.Dll")]
        public static extern int GetSystemMetrics(int nIndex);

        public static D2.Axis GetBoundaries()
        {
            return new D2.Axis (GetSystemMetrics(0), GetSystemMetrics(1));
        }

        public static D2.Axis GetAxis(ScreenAnchor anchor)
        {
            switch (anchor)
            {
                case ScreenAnchor.UpperLeft:
                    return new D2.Axis(0, 0);
                case ScreenAnchor.UpperMiddle:
                    return new D2.Axis(GetSystemMetrics(0)/2, 0);
                case ScreenAnchor.UpperRight:
                    return new D2.Axis(GetSystemMetrics(0), 0);
                case ScreenAnchor.CenterLeft:
                    return new D2.Axis(0, GetSystemMetrics(1) / 2);
                case ScreenAnchor.CenterMiddle:
                    return new D2.Axis(GetSystemMetrics(0)/2, GetSystemMetrics(1)/2);
                case ScreenAnchor.CenterRight:
                    return new D2.Axis(GetSystemMetrics(0), GetSystemMetrics(1)/2);
                case ScreenAnchor.BottonLeft:
                    return new D2.Axis(0, GetSystemMetrics(1));
                case ScreenAnchor.BottonMiddle:
                    return new D2.Axis(GetSystemMetrics(0) / 2, GetSystemMetrics(1));
                case ScreenAnchor.BottonRight:
                    return new D2.Axis(GetSystemMetrics(0), GetSystemMetrics(1));
                default:
                    return new D2.Axis(GetSystemMetrics(0), GetSystemMetrics(1));
            }
            
        }
    }
}
