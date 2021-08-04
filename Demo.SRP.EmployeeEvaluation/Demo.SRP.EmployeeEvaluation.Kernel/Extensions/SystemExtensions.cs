using System;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Extensions
{
    public static class SystemExtensions
    {
        public static void Display(this object value)
        {
            Console.WriteLine(value: value);
        }
    }
}