using Xunit;

namespace ExampleApp.Tests
{
    public class ExampleTest
    {
        [Fact]
        public void FormulaTest()
        {
            var formula = 1 + 1;

            Assert.True(formula == 2, "Formula should be 2");
        }
    }
}
