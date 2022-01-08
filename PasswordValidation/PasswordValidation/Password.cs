using System;

namespace PasswordValidation
{
    public class Password
    {
        private readonly string _inputPassword;
        
        public Password(string inputPassword)
        {
            _inputPassword = inputPassword;
        }

        public bool IsValid()
        {
            int hasNum = 0;
            int hasCap = 0;
            int hasSpecialChar = 0;

           foreach (var character in _inputPassword)
            {
                if (char.IsDigit(character))
                    hasNum++;
                    
                if (char.IsUpper(character))
                    hasCap++;
                    
                if (!char.IsLetterOrDigit(character))
                    hasSpecialChar++;

                if (hasNum >= 2 && hasCap >= 1 && hasSpecialChar >= 1)
                    return true;
            }

           if (_inputPassword.Length < 8)
               Console.WriteLine("Password must be at least 8 characters");

           if (hasNum < 2)
               Console.WriteLine("Password must contain at least 2 numbers");

           if (hasCap < 1)
               Console.WriteLine("Password must contain at least one capital letter");

           if (hasSpecialChar < 1)
               Console.WriteLine("Password must contain at least one special character");

            return false;
        }
    }
}