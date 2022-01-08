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
            
            if (_inputPassword.Length >= 8)
                foreach (var character in _inputPassword)
                {
                    if (char.IsDigit(character))
                    {
                        hasNum++;
                        if (hasNum >= 2)
                            return true; 
                    }
                }
            
            return false;
        }
    }
}