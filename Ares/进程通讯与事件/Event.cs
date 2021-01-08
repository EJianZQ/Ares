using System;
using System.Threading;

namespace Ares
{
    class Event
    {
        public static EventWaitHandle ProgramStarted;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public static bool CreateEvent(string lpName)
        {
            Event.ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, lpName, out bool isCreateSuccessfully);
            return isCreateSuccessfully;
        }
    }
}
