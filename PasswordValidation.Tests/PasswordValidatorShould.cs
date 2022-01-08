using Xunit;

namespace PasswordValidation.Tests
{
    
    public class PasswordValidatorShould
    {
        
        [Theory]
        [InlineData("jshuyro")]
        [InlineData("posdk3fhdsoiu")]
        public void FailWhenLess8CharsAndNoNumbers(string givenPass)
        {
            var pass = new Password(givenPass);
            Assert.False(pass.IsValid());
        }

        [Fact]
        public void FailWhenNoCapitalLetter()
        {
            var pass = new Password("oiuysjdh43");
            Assert.False(pass.IsValid());
        }

        [Theory]
        [InlineData("pos8dk3o")]
        [InlineData("posdkg3g3dsoiu")]
        public void PassWhen8CharsOrMoreAnd2OrMoreNums(string givenPass)
        {
            var pass = new Password(givenPass);
            Assert.True(pass.IsValid());
        }

    }
}