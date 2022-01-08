using Xunit;

namespace PasswordValidation.Tests
{
    
    public class PasswordValidatorShould
    {
        
        [Theory]
        [InlineData("jshuyro")]
        [InlineData("posdk3fhdsoiu")]
        [InlineData("oiuysjdh43")]
        public void FailWhenLess8CharsAndNoNumbers(string givenPass)
        {
            var pass = new Password(givenPass);
            Assert.False(pass.IsValid());
        }

       
        [Theory]
        [InlineData("pOs8dk3o")]
        [InlineData("Posdkg3g3dsoiu")]
        public void PassWhen8CharsOrMoreAnd2OrMoreNums(string givenPass)
        {
            var pass = new Password(givenPass);
            Assert.True(pass.IsValid());
        }

    }
}