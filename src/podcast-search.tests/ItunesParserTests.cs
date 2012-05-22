using System.IO;

using FluentAssertions;

using NUnit.Framework;

using podcast_search.Parsers;

namespace podcast_search.tests
{
    [TestFixture]
    public class ItunesParserTests
    {
        private ItunesParser parser;

        [SetUp]
        public void Init()
        {
            parser = new ItunesParser();
        }

        [Test]
        public void Parse_Returns_Empty_Enumerable_If_Passed_Empty_String()
        {
            var results = parser.Parse("");

            results.Should().BeEmpty();
        }

        [Test]
        public void Parse_Returns_Empty_Enumerable_If_Passed_Non_Html()
        {
            var results = parser.Parse("Test Test");

            results.Should().BeEmpty();
        }

        [Test]
        public void Parse_Returns_Empty_Enumerable_If_Passed_Invalid_Html()
        {
            var html = "<html><body><div>Some Text</div><a href='http://www.123.com'>link</a></body></html>";
            var results = parser.Parse(html);

            results.Should().BeEmpty();
        }

        [Test]
        public void Parse_Returns_Enumerable_From_Valid_Page()
        {
            var html = File.ReadAllText("./Test-Data/ItunesTestPage.html");
            var results = parser.Parse(html);

            results.Should().NotBeEmpty();
        }
    }
}