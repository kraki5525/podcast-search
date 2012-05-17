using CLAP;

using NUnit.Framework;

using podcast_search.Validation;

namespace podcast_search.tests
{
    [TestFixture]
    public class IsUriValidatorTests
    {
        private readonly IsUriValidator validator;
        public IsUriValidatorTests()
        {
            validator = new IsUriValidator();
        }

        [Test]
        public void Validate_Throws_Error_On_Invalid_Uri()
        {
            var invalidUri = "htp://www.test.com/";

            validator.ValidateUri(invalidUri);
        }
    }
}