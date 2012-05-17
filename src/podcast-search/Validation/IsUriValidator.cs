using System;

using CLAP;

namespace podcast_search.Validation
{
    public class IsUriValidator : IValueValidator {
        public void Validate(ValueInfo info)
        {
            ValidateUri(info.Value.ToString());
        }

        public void ValidateUri(string invalidUri)
        {
            if (!Uri.IsWellFormedUriString(invalidUri, UriKind.RelativeOrAbsolute))
            {
                throw new ValidationException(string.Format("You must specify a valid uri.  {0} is not considered a valid uri.", invalidUri));
            }
        }
    }
}