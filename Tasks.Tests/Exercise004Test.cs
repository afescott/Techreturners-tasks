using Xunit;
using TechReturners.Tasks;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks.UnitTests
{
    public class Exercise004Test
    {
        [Fact]
        public void CheckStringAsPigLatin()
        {
            Assert.Equal("igPay atinlay siay oolcay", Exercise004.PigIt("Pig latin is cool"));
            Assert.Equal("hisTay siay ymay tringsay", Exercise004.PigIt("This is my string"));
        }

        [Fact]
        public void CheckIgnorePunctuation()
        {
            Assert.Equal("igPay atinlay siay oolcay!!", Exercise004.PigIt("Pig latin is cool!!"));
        }
    }
}