using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlTestCSWinForm
{

    [StructLayout(LayoutKind.Sequential)]
    internal struct UNICODE_STRING
    {
        public ushort Length;
        public ushort MaximumLength;
        public IntPtr Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct SYSTEM_PROCESS_INFORMATION
    {
        public uint NextEntryOffset;
        public uint NumberOfThreads;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] Reserved1;
        public UNICODE_STRING ImageName;
        public int BasePriority;
        public IntPtr UniqueProcessId;
        public IntPtr Reserved2;
        public uint HandleCount;
        public uint SessionId;
        public IntPtr Reserved3;
        public UIntPtr PeakVirtualSize;
        public UIntPtr VirtualSize;
        public uint Reserved4;
        public UIntPtr PeakWorkingSetSize;
        public UIntPtr WorkingSetSize;
        public IntPtr Reserved5;
        public UIntPtr QuotaPagedPoolUsage;
        public IntPtr Reserved6;
        public UIntPtr QuotaNonPagedPoolUsage;
        public UIntPtr PagefileUsage;
        public UIntPtr PeakPagefileUsage;
        public UIntPtr PrivatePageCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public long[] Reserved7;
    }

    /// <summary>
    /// SYSTEM_PROCESS_INFORMATION構造体のデータを保持するクラスです。
    /// </summary>
    [DebuggerDisplay("{ImageName} ({UniqueProcessId})")]
    internal class SystemProcessInformation
    {
        private uint numberOfThreads;
        private string imageName;
        private int basePriority;
        private IntPtr uniqueProcessId;
        private uint handleCount;
        private uint sessionId;
        private UIntPtr peakVirtualSize;
        private UIntPtr virtualSize;
        private UIntPtr peakWorkingSetSize;
        private UIntPtr workingSetSize;
        private UIntPtr quotaPagedPoolUsage;
        private UIntPtr quotaNonPagedPoolUsage;
        private UIntPtr pagefileUsage;
        private UIntPtr peakPagefileUsage;
        private UIntPtr privatePageCount;

        public uint NumberOfThreads { get => numberOfThreads; set => numberOfThreads = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public int BasePriority { get => basePriority; set => basePriority = value; }
        public IntPtr UniqueProcessId { get => uniqueProcessId; set => uniqueProcessId = value; }
        public uint HandleCount { get => handleCount; set => handleCount = value; }
        public uint SessionId { get => sessionId; set => sessionId = value; }
        public UIntPtr PeakVirtualSize { get => peakVirtualSize; set => peakVirtualSize = value; }
        public UIntPtr VirtualSize { get => virtualSize; set => virtualSize = value; }
        public UIntPtr PeakWorkingSetSize { get => peakWorkingSetSize; set => peakWorkingSetSize = value; }
        public UIntPtr WorkingSetSize { get => workingSetSize; set => workingSetSize = value; }
        public UIntPtr QuotaPagedPoolUsage { get => quotaPagedPoolUsage; set => quotaPagedPoolUsage = value; }
        public UIntPtr QuotaNonPagedPoolUsage { get => quotaNonPagedPoolUsage; set => quotaNonPagedPoolUsage = value; }
        public UIntPtr PagefileUsage { get => pagefileUsage; set => pagefileUsage = value; }
        public UIntPtr PeakPagefileUsage { get => peakPagefileUsage; set => peakPagefileUsage = value; }
        public UIntPtr PrivatePageCount { get => privatePageCount; set => privatePageCount = value; }

        public SystemProcessInformation()
        {
        }

        public SystemProcessInformation(ref SYSTEM_PROCESS_INFORMATION info)
        {
            numberOfThreads = info.NumberOfThreads;
            imageName = Marshal.PtrToStringUni(info.ImageName.Buffer);
            basePriority = info.BasePriority;
            uniqueProcessId = info.UniqueProcessId;
            handleCount = info.HandleCount;
            sessionId = info.SessionId;
            peakVirtualSize = info.PeakVirtualSize;
            virtualSize = info.VirtualSize;
            peakWorkingSetSize = info.PeakWorkingSetSize;
            workingSetSize = info.WorkingSetSize;
            quotaPagedPoolUsage = info.QuotaPagedPoolUsage;
            quotaNonPagedPoolUsage = info.QuotaNonPagedPoolUsage;
            pagefileUsage = info.PagefileUsage;
            peakPagefileUsage = info.PeakPagefileUsage;
            privatePageCount = info.PrivatePageCount;
        }


    }
}
