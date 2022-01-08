using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = new Password("us45!u");
            pass.IsValid();
        }
    }
}