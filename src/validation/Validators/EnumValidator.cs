using System;

namespace Validation.Validators
{
    public class EnumValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid enumator.";

        public EnumValidator(Enum value) : base(value)
        {
        }

        public EnumValidator Be(Enum otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<Enum>().Equals(otherValue), error, args);
            return this;
        }

        public EnumValidator NotBe(Enum otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => !GetValue<Enum>().Equals(otherValue), error, args);
            return this;
        }
    }
}