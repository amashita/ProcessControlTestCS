using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlTestCSWinForm
{

    internal class ProcessController
    {

        private static class NativeMethods
        {
            [DllImport("ntdll.dll", SetLastError = false, ExactSpelling = true)]
            public static extern int NtQuerySystemInformation(
                int SystemInformationClass,
                byte[] SystemInformation,
                uint SystemInformationLength,
                out uint ReturnLength);
        }

        private enum SYSTEM_INFORMATION_CLASS : int
        {
            // SystemBasicInformation = 0,
            // SystemPerformanceInformation = 2,
            // SystemTimeOfDayInformation = 3,
            SystemProcessInformation = 5,
            // SystemProcessorPerformanceInformation = 8,
            // SystemInterruptInformation = 23,
            // SystemExceptionInformation = 33,
            // SystemRegistryQuotaInformation = 37,
            // SystemLookasideInformation = 45,
            // SystemCodeIntegrityInformation = 103,
            // SystemPolicyInformation = 134,
        }


        public List<SystemProcessInformation> GetProcessInfo()
        {
            const int STATUS_INFO_LENGTH_MISMATCH = unchecked((int)0xC0000004);

            // SystemProcessInformationのすべての情報を取得します。
            var buffer = Array.Empty<byte>();
            for (; ; )
            {
                var status = NativeMethods.NtQuerySystemInformation(
                        (int)SYSTEM_INFORMATION_CLASS.SystemProcessInformation,
                        buffer, (uint)buffer.LongLength, out var bufferLength);
                if (status != STATUS_INFO_LENGTH_MISMATCH)
                {
                    if (status == 0)
                        break;
                    throw new NTStatusException(status);
                }
                Array.Resize(ref buffer, (int)bufferLength);
            }

            // SystemProcessInformationの情報を解析します。
            var infos = new List<SystemProcessInformation>();
            var bufferHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                var address = bufferHandle.AddrOfPinnedObject();
                for (; ; )
                {
                    // GCHandleの解放後はSYSTEM_PROCESS_INFORMATIONのImageNameの値が無効となるため、
                    // 文字列をメモリから変数に保持するクラスへ変換します。
                    var info = Marshal.PtrToStructure<SYSTEM_PROCESS_INFORMATION>(address);
                    infos.Add(new SystemProcessInformation(ref info));
                    if (info.NextEntryOffset == 0)
                        break;
                    address = IntPtr.Add(address, (int)info.NextEntryOffset);
                }
            }
            finally
            {
                bufferHandle.Free();
            }

//#if DEBUG
//            foreach (var info in infos)
//            {
//                Console.WriteLine($"{info.ImageName}, {info.UniqueProcessId}");
//            }
//#endif

            return infos;
        }

    }
}
