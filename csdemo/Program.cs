using System;
using System.Runtime.InteropServices;

namespace csdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0){
                System.Reflection.FieldInfo fieldInfo = null;
                SafeHandle handle = (SafeHandle)fieldInfo.GetValue(args[0]);
                IntPtr dangerousHandle = handle.DangerousGetHandle();
                int? nullable = null;
                Console.WriteLine(nullable.Value);
                IntPtr anotherDangerousHandle = handle.DangerousGetHandle();
            }
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello there!");
            Environment.Exit(0);
        }
    }
}
