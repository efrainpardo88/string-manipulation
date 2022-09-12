using Xunit;
using System.Text;

namespace StringManipulation.Test
{
    public class StringManipulationTest
    {
        App.StringManipulation stringManipulation = new();

        [Fact]
        public void Test1()
        {
            var result = stringManipulation.sortingOperations(2, new string[] { "abaccadcc", "xyzxy" });
        }
    }
}