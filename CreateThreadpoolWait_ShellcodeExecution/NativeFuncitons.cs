using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CreateThreadpoolWait_ShellcodeExecution
{
    public class NativeFuncitons
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateEvent(
            IntPtr lpEventAttributes, 
            bool bManualReset, 
            bool bInitialState, 
            string lpName
        );

        [DllImport("kernel32")]
        public static extern IntPtr VirtualAlloc(
            IntPtr lpStartAddr,
            UInt32 size, 
            UInt32 flAllocationType, 
            UInt32 flProtect);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateThreadpoolWait(IntPtr callback_function, uint pv, uint pcb);

        [DllImport("kernel32.dll")]
        public static extern void SetThreadpoolWait(IntPtr TP_WAIT_pointer, IntPtr Event_handle, IntPtr pftTimeout);

        [DllImport("kernel32")]
        public static extern UInt32 WaitForSingleObject(
            IntPtr hHandle,
            UInt32 dwMilliseconds);
    }
}
