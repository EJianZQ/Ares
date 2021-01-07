using System;
using System.Threading;

namespace Ares
{
    public class MutexEx
    {
        public static bool CreateMutex(string MutexName)
        {
            Mutex m = new Mutex(false, MutexName,  out bool ifSuccessful);
            if(ifSuccessful == true)
                return true;
            else
                return false;
        }
    }
}
