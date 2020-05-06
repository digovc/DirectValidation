using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_enum_validations : nspec
    {
        private enum TestEnum
        {
            One,
            Two,
        }

        public void it_validate_be()
        {
            TestEnum.One.Validate().Be(TestEnum.One);
            new Action(() => TestEnum.One.Validate().Be(TestEnum.Two)).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            TestEnum.One.Validate().NotBe(TestEnum.Two);
            new Action(() => TestEnum.One.Validate().NotBe(TestEnum.One)).Should().Throw<ValidationException>();
        }
    }
}