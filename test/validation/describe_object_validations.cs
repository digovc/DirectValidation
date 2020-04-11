using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_object_validations : nspec
    {
        public void it_validate_be()
        {
            true.Validate().Be(true);
            new Action(() => true.Validate().Be(false)).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            true.Validate().NotBe(false);
            new Action(() => true.Validate().NotBe(true)).Should().Throw<ValidationException>();
        }
    }
}