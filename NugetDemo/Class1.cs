using System;

namespace NugetDemo
{
    public class Class1
    {
        public string Platform
        {
            get
            {
#if NETCOREAPP2_2
                return "NETCOREAPP2_2";
#elif NET48
                return "NET48";
#elif NET45
                return "NET45";
#elif NETSTANDARD2_0
                return "NETSTANDARD2_0";
#else
#error This code block does not match csproj TargetFrameworks list
#endif
            }
        }
    }
}
