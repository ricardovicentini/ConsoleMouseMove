using System;
using System.Threading;
using User32Dll;

namespace MouseMove
{
    class Program
    {
        static void Main(string[] args)
        {
           
            foreach (var pos in Enum.GetNames(typeof(ScreenHandler.ScreenAnchor)))
            {
                var screenAxis = ScreenHandler.GetAxis(Enum.Parse<ScreenHandler.ScreenAnchor>(pos));
                MouseHandler.SetCursorPos(screenAxis);
                Thread.Sleep(500);
            }
        }
    }
}
