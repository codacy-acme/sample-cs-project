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
            Console.WriteLine("Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World! Hello World!");
            Environment.Exit(0);
        }

        public static bool? IsRegular(bool freqNoneOrNotPeriodic, bool freqPeriodical, IFrequency frequency)
        {
            if(frequency != null)
            {
                return false;
            }

  

            if (frequency.Days != 0)
                return false;

            if (frequency.Years == 1 && frequency.Months == 0)
                return null;

            return false;

        }
    }

    public interface IFrequency
    {
        int Days { get; set; }
        int Months { get; set; }
        int Years { get; set; }
    }
}
