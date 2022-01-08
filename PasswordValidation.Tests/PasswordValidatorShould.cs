using Xunit;

namespace PasswordValidation.Tests
{
    
    public class PasswordValidatorShould
    {
        [Fact]
        public void FailIfLessThan8Chars()
        {
            var pass = new Password("jshuyro");
            Assert.False(pass.IsValid());
        }

        [Fact]
        public void PassIfPasswordIs8Chars()
        {
            var pass = new Password("posdkoiu");
            Assert.True(pass.IsValid());
        }

        [Fact]
        public void PassIfPasswordIs8OrMoreChars()
        {
            var pass = new Password("posdkggdsoiu");
            Assert.True(pass.IsValid());
        |
    }
}