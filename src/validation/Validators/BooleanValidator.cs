namespace Validation.Validators
{
    public class BooleanValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid boolean.";

        public BooleanValidator(bool value) : base(value)
        {
        }

        public BooleanValidator Be(bool otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<bool>() == otherValue, error, args);
            return this;
        }

        public BooleanValidator BeFalse(string error = DefaultError, params object[] args)
        {
            Execute(() => !GetValue<bool>(), error, args);
            return this;
        }

        public BooleanValidator BeTrue(string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<bool>(), error, args);
            return this;
        }

        public BooleanValidator NotBe(bool otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<bool>() != otherValue, error, args);
            return this;
        }
    }
}