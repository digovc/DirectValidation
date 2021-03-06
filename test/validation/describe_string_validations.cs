﻿using FluentAssertions;
using NSpec;
using System;
using Validation;

namespace Test
{
    public class describe_string_validations : nspec
    {
        private readonly string value = "ABC";
        private readonly string value2 = "123";

        public void it_validate_be()
        {
            value.Validate().Be(value);
            new Action(() => value.Validate().Be(value2)).Should().Throw<ValidationException>();
        }

        public void it_validate_match()
        {
            "test@email.com".Validate().Match(Patterns.EmailPattern);
            new Action(() => "testemailcom".Validate().Match(Patterns.EmailPattern)).Should().Throw<ValidationException>();
        }

        public void it_validate_not_be()
        {
            value.Validate().NotBe(value2);
            new Action(() => value.Validate().NotBe(value)).Should().Throw<ValidationException>();
        }
    }
}