using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlTestCSWinForm
{
    public static partial class NTStatusUtility
    {
        public static bool IsSuccess(int status) => status >= 0;
        public static bool IsInformation(int status) => (status >> 30) == 1;
        public static bool IsWarning(int status) => (status >> 30) == 2;
        public static bool IsError(int status) => (status >> 30) == 3;

        public static int HResultFromNTStatus(int status)
        {
            const int FACILITY_NT_BIT = 0x10000000;
            return status | FACILITY_NT_BIT;
        }
    }

    internal sealed class NTStatusException : COMException
    {
        public NTStatusException()
            : base()
        {
            status = 0;
        }

        public NTStatusException(int status)
            : base(null, NTStatusUtility.HResultFromNTStatus(status))
        {
            this.status = status;
        }

        public NTStatusException(string message, int status)
            : base(message, NTStatusUtility.HResultFromNTStatus(status))
        {
            this.status = status;
        }

        public NTStatusException(string message, Exception inner)
            : base(message, inner)
        {
            this.status = 0;
        }

        public NTStatusException(string message)
            : base(message)
        {
            this.status = 0;
        }

        private int status;
        public int Status => status;
    }
}
