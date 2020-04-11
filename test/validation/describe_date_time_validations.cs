using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_date_time_validations : nspec
    {
        private readonly DateTime value = DateTime.Now;
        private readonly DateTime value2 = DateTime.Now.AddDays(1);

        public void it_validate_be()
        {
            value.Validate().Be(value);
            new Action(() => value.Validate().Be(value2)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_after()
        {
            value2.Validate().BeAfter(value);
            new Action(() => value.Validate().BeAfter(value2)).Should().Throw<ValidationException>();
            new Action(() => value.Validate().BeAfter(value)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_before()
        {
            value.Validate().BeBefore(value2);
            new Action(() => value2.Validate().BeBefore(value)).Should().Throw<ValidationException>();
            new Action(() => value.Validate().BeBefore(value)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_on_or_after()
        {
            value2.Validate().BeOnOrAfter(value);
            value2.Validate().BeOnOrAfter(value2);
            new Action(() => value.Validate().BeOnOrAfter(value2)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_on_or_before()
        {
            value.Validate().BeOnOrBefore(value2);
            value.Validate().BeOnOrBefore(value);
            new Action(() => value2.Validate().BeOnOrBefore(value)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_same_date()
        {
            value.Validate().BeSameDateAs(value);
            new Action(() => value2.Validate().BeSameDateAs(value)).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            value.Validate().NotBe(value2);
            new Action(() => value.Validate().NotBe(value)).Should().Throw<ValidationException>();
        }
    }
}