using System.Linq;
using System;

namespace OYASAR.Penguin.Api.Helper
{
    public static class DomainHelper
    {
        public static readonly string DomainAddr;
        public static readonly string BaseDirForDll;

        private const char splitKey = '/';

        static DomainHelper()
        {
            DomainAddr = AppContext.BaseDirectory;
            BaseDirForDll = AppContext.BaseDirectory;
        }

        public static string ToTakeFileFromUrl(this string str)
        {
            return str.Split(splitKey).Last();
        }

        public static string ToNewUrlForFile(this string str)
        {
            return $"{DomainAddr}/{str.ToTakeFileFromUrl()}";
        }
    }
}
