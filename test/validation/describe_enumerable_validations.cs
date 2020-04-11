using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_enumerable_validations : nspec
    {
        private readonly string[] nullValue;
        private readonly string[] value = new string[] { "a", "b", "c" };
        private readonly string[] value2 = new string[] { "1", "2", "3" };

        public void it_validate_be()
        {
            value.Validate().Be(value);
            new Action(() => value.Validate().Be(value2)).Should().Throw<ValidationException>();
        }

        public void it_validate_be_empty()
        {
            new string[] { }.Validate().BeEmpty();
            new Action(() => value.Validate().BeEmpty()).Should().Throw<ValidationException>();
        }

        public void it_validate_be_null_or_empty()
        {
            nullValue.Validate().BeNullOrEmpty();
            new string[] { }.Validate().BeNullOrEmpty();
            new Action(() => value.Validate().BeNullOrEmpty()).Should().Throw<ValidationException>();
        }

        public void it_validate_have_count()
        {
            value.Validate().HaveCount(3);
            new Action(() => value.Validate().HaveCount(0)).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            value.Validate().NotBe(value2);
            new Action(() => value.Validate().NotBe(value)).Should().Throw<ValidationException>();
        }
    }
}