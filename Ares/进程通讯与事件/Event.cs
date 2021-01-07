using System;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;

namespace Ares
{
    class Event
    {
        public static EventWaitHandle ProgramStarted;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public static bool CreateEvent(string lpName)
        {
            Event.ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, lpName, out bool createNew);
            if (createNew == true)
                return true;
            else
                return false;
        }
    }
}
