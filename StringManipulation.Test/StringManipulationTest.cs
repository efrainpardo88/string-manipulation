using Xunit;
using System.Text;

namespace StringManipulation.Test
{
    public class StringManipulationTest
    {
        App.StringManipulation stringManipulation = new();

        [Fact]
        public void StringManipulationWithoutParamsTest()
        {
            // Get result
            var result = stringManipulation.sortingOperations();

            // Validate result
            Assert.Equal("-404", result);
        }

        [Fact]
        public void StringManipulationWithInconsistentLengthTest()
        {
            // Get result
            var strArray = new string[]
            {
                "abaccadcc",
                "xyzxy"
            };
            var result = stringManipulation.sortingOperations(10, strArray);

            // Validate result
            Assert.Equal("-404", result);
        }

        [Fact]
        public void StringManipulationTest1()
        {
            // Get result
            var strArray = new string[]
            {
                "abaccadcc",
                "xyzxy"
            };
            var result = stringManipulation.sortingOperations(2, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("ccccaaabd");
            expected.AppendLine("xxyyz");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }

        [Fact]
        public void StringManipulationTest2()
        {
            // Get result
            var strArray = new string[]
            {
                "dulgvgzwqg",
                "gxtjtmtywr",
                "hnlnxiupgt",
                "gzjotckivp",
                "dpwwsdptae",
                "pcscpilknb",
                "btvyhhmflf",
                "artrtnqxcr",
                "nrtcmcoadn",
                "fkdsgnekft"
            };
            var result = stringManipulation.sortingOperations(10, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("gggdlquvwz");
            expected.AppendLine("tttgjmrwxy");
            expected.AppendLine("nnghilptux");
            expected.AppendLine("cgijkoptvz");
            expected.AppendLine("ddppwwaest");
            expected.AppendLine("ccppbiklns");
            expected.AppendLine("ffhhblmtvy");
            expected.AppendLine("rrrttacnqx");
            expected.AppendLine("ccnnadmort");
            expected.AppendLine("ffkkdegnst");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }

        [Fact]
        public void StringManipulationTest3()
        {
            // Get result
            var strArray = new string[]
            {
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc"
            };
            var result = stringManipulation.sortingOperations(5, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("eeuuwwabnz");
            expected.AppendLine("fklnovwxyz");
            expected.AppendLine("eedfklnrxy");
            expected.AppendLine("ddafgioqsw");
            expected.AppendLine("ccbfikuvyz");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }

        [Fact]
        public void StringManipulationTest4()
        {
            // Get result
            var strArray = new string[]
            {
                "qakmc",
                "rrtbk",
                "vaixn",
                "wmpnj",
                "uproi",
                "btska",
                "ejqwr",
                "elwlg",
                "oaoiy",
                "hrqkn"
            };
            var result = stringManipulation.sortingOperations(10, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("ackmq");
            expected.AppendLine("rrbkt");
            expected.AppendLine("ainvx");
            expected.AppendLine("jmnpw");
            expected.AppendLine("iopru");
            expected.AppendLine("abkst");
            expected.AppendLine("ejqrw");
            expected.AppendLine("llegw");
            expected.AppendLine("ooaiy");
            expected.AppendLine("hknqr");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }

        [Fact]
        public void StringManipulationTest5()
        {
            // Get result
            var strArray = new string[]
            {
                "pzjim",
                "njnfq",
                "xyohs"
            };
            var result = stringManipulation.sortingOperations(3, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("ijmpz");
            expected.AppendLine("nnfjq");
            expected.AppendLine("hosxy");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }

        [Fact]
        public void StringManipulationTest6()
        {
            // Get result
            var strArray = new string[]
            {
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys"
            };
            var result = stringManipulation.sortingOperations(5, strArray);

            // Expected Result
            var expected = new StringBuilder();
            expected.AppendLine("cqsxy");
            expected.AppendLine("abeox");
            expected.AppendLine("afkos");
            expected.AppendLine("bdilt");
            expected.AppendLine("grswy");

            // Validate result
            Assert.Equal(expected.ToString(), result);
        }
    }
}