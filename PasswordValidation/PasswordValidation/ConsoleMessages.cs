using System;

namespace PasswordValidation
{
    public class ConsoleMessages
    {
        private readonly Password _password;

        public ConsoleMessages(Password password)
        {
            _password = password;
        }

        public void ErrorMessage(int hasNum, int hasCap, int hasSpecialChar)
        {
            if (_password.InputPassword.Length < 8)
                Console.WriteLine("Password must be at least 8 characters");

            if (hasNum < 2)
                Console.WriteLine("Password must contain at least 2 numbers");

            if (hasCap < 1)
                Console.WriteLine("Password must contain at least one capital letter");

            if (hasSpecialChar < 1)
                Console.WriteLine("Password must contain at least one special character");
        }
    }
}