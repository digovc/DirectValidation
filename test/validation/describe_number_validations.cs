using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_number_validations : nspec
    {
        public void it_validate_be()
        {
            0.Validate().Be(0);
            new Action(() => 0.Validate().Be(1)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_greater_or_equal()
        {
            0.Validate().BeGreaterOrEqualTo(0);
            1.Validate().BeGreaterOrEqualTo(0);
            new Action(() => 0.Validate().BeGreaterOrEqualTo(1)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_greater_than()
        {
            1.Validate().BeGreaterThan(0);
            new Action(() => 0.Validate().BeGreaterThan(1)).Should().Throw<ValidationException>();
            new Action(() => 0.Validate().BeGreaterThan(0)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_less_or_equal()
        {
            0.Validate().BeLessOrEqualTo(0);
            0.Validate().BeLessOrEqualTo(1);
            new Action(() => 1.Validate().BeLessOrEqualTo(0)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_less_than()
        {
            0.Validate().BeLessThan(1);
            new Action(() => 1.Validate().BeLessThan(0)).Should().Throw<ValidationException>();
            new Action(() => 0.Validate().BeLessThan(0)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_negative()
        {
            (-1).Validate().BeNegative();
            new Action(() => 0.Validate().BeNegative()).Should().Throw<ValidationException>();
        }

        public void it_validate_be_positive()
        {
            0.Validate().BePositive();
            1.Validate().BePositive();
            new Action(() => (-1).Validate().BePositive()).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            0.Validate().NotBe(1);
            new Action(() => 0.Validate().NotBe(0)).Should().Throw<ValidationException>();
        }
    }
}