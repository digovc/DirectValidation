using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_validations : nspec
    {
        public void it_validate_string()
        {
            var error = "This must fail.";
            new Action(() => string.Empty.Validate().NotNullOrWhiteSpace(error)).Should().Throw<ValidationException>().WithMessage(error);
            new Action(() => "   ".Validate().NotNullOrWhiteSpace(error)).Should().Throw<ValidationException>().WithMessage(error);
            "ABC".Validate().NotNullOrWhiteSpace(error);
        }
    }
}