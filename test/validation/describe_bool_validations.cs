using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_bool_validations : nspec
    {
        public void it_validate_be()
        {
            true.Validate().Be(true);
            new Action(() => true.Validate().Be(false)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_false()
        {
            false.Validate().BeFalse();
            new Action(() => true.Validate().BeFalse()).Should().Throw<ValidationException>();
        }

        public void it_validate_be_true()
        {
            true.Validate().BeTrue();
            new Action(() => false.Validate().BeTrue()).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            true.Validate().NotBe(false);
            new Action(() => true.Validate().NotBe(true)).Should().Throw<ValidationException>();
        }
    }
}