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

        [Fact]
        public void FailWhenThereAreNoSpecialChars()
        {
            var pass = new Password("oiU98iskp");
            Assert.False(pass.IsValid());
        }

       
        [Theory]
        [InlineData("pOs8dk3&o")]
        [InlineData("Posdkg3g3dso!iu")]
        public void PassWhen8CharsOrMoreAnd2OrMoreNums(string givenPass)
        {
            var pass = new Password(givenPass);
            Assert.True(pass.IsValid());
        }

    }
}