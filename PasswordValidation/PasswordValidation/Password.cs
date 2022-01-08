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
            if (_inputPassword.Length == 8)
                return true;
            
            return false;
        }
    }
}