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
                for (int i = 0; i < _inputPassword.Length; i++)
                {
                    char currentChar = _inputPassword[i];
                    if (char.IsDigit(currentChar))
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