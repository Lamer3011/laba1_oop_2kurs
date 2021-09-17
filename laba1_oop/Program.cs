using System;

namespace laba1_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatingSystem OS = System.Environment.OSVersion;
            Console.WriteLine($"Your OS {OS.Platform} \nCurrent time: {System.DateTime.Now}");
        }
    }
}
