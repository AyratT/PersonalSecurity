﻿namespace PersonalSecurity.Crypto
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    internal static class SecureStringExstension
    {
        public static string ConvertToString(this SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
    }
}
