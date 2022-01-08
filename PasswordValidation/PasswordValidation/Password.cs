using System;

namespace PasswordValidation
{
    public class Password
    {
        public readonly string _inputPassword;
        private readonly ConsoleMessages _consoleMessages;

        public Password(string inputPassword)
        {
            _inputPassword = inputPassword;
            _consoleMessages = new ConsoleMessages(this);
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

            _consoleMessages.ErrorMessage(hasNum, hasCap, hasSpecialChar);

            return false;
        }
    }
}