using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_validations : nspec
    {
        public void it_validate_number()
        {
        }

        public void it_validate_object()
        {
            object obj = null;
            new Action(() => obj.Validate().NotBeNull()).Should().Throw<ValidationException>();
            new object().Validate().NotBeNull();
        }

        public void it_validate_string()
        {
            var stringValue = "This is a string.";
            new Action(() => string.Empty.Validate().NotBeNullOrWhiteSpace(stringValue)).Should().Throw<ValidationException>().WithMessage(stringValue);
            new Action(() => "   ".Validate().NotBeNullOrWhiteSpace(stringValue)).Should().Throw<ValidationException>().WithMessage(stringValue);
            stringValue.Validate().NotBeNullOrWhiteSpace(stringValue);
            stringValue.Validate().HaveLength(stringValue.Length);
        }
    }
}