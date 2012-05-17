using CLAP;

namespace podcast_search.Validation
{
    public class IsUriAttribute : ValidationAttribute
    {
        public override IValueValidator GetValidator()
        {
            return new IsUriValidator();
        }

        public override string Description
        {
            get { return "Uri is a valid uri"; }
        }
    }
}