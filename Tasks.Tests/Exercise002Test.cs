using Xunit;
using TechReturners.Tasks;
using System.Collections.Generic;

// The clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
// Your task is to make the 'past' function return the time converted to milliseconds.
// More examples in the test cases below.

namespace TechReturners.Tasks.UnitTests
{
    public class Exercise002Test
    {
        [Fact]
        public void CheckPast()
        {
            Assert.Equal(61000, Exercise002.Past(0, 1, 1));
            Assert.Equal(3661000, Exercise002.Past(1, 1, 1));
            Assert.Equal(0, Exercise002.Past(0, 0, 0));
            Assert.Equal(3601000, Exercise002.Past(1, 0, 1));
            Assert.Equal(3600000, Exercise002.Past(1, 0, 0));


        }
    }
}
