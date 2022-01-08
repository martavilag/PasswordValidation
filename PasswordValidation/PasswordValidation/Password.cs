using System;

namespace PasswordValidation
{
    public class Password
    {
        private string _inputPassword;

        public Password(string inputPassword)
        {
            _inputPassword = inputPassword;
        }

        public bool IsValid()
        {
            int hasNum = 0;
            int hasCap = 0;
            int hasSpecialChar = 0;
            
            if (_inputPassword.Length >= 8)
                foreach (var character in _inputPassword)
                {
                    if (char.IsDigit(character))
                    {
                        hasNum++;
                    }

                    if (char.IsUpper(character))
                    {
                        hasCap++;
                    }

                    if (!char.IsLetterOrDigit(character))
                    {
                        hasSpecialChar++;
                    }

                    if (hasNum >= 2 && hasCap >= 1 && hasSpecialChar >= 1)
                        return true;
                }
            
            return false;
        }
    }
}