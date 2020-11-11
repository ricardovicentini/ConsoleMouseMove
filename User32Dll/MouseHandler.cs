using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace User32Dll
{
    public static class MouseHandler
    {
        public enum MouseEventFlags
        { 
            LeftButtonDown = 0x00000002,
            LeftButtonUp = 0x00000004,
            MiddleWheelDown = 0x00000020,
            MiddleWheelUP = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightButtonDown = 0x00000008,
            RightButtonUp = 0x00000010
        }

        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);
        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref D2.Axis point);
        [DllImport("User32.Dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void ThrowMouseEvent(MouseEventFlags flag, int pos_x, int pos_y, int data, int extraInfo)
        {
            
            mouse_event((int)flag, pos_x, pos_y, data, extraInfo);
        }

        public static void SetCursorPos(D2.Axis axis, bool throwMouseEvent = true)
        {
            SetCursorPos(axis.Horizontal, axis.Vertical);
            if (throwMouseEvent)
                ThrowMouseEvent(MouseEventFlags.Move, 0,0, 0, 0);
        }
    }
}
