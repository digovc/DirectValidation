namespace Validation.Validators
{
    public class NumberValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid number.";

        public NumberValidator(decimal value) : base(value)
        {
        }

        public ObjectValidator BeGreaterOrEqualTo(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() >= value, error);
            return this;
        }

        public ObjectValidator BeGreaterThan(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() > value, error);
            return this;
        }

        public ObjectValidator BeLessOrEqualTo(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() <= value, error);
            return this;
        }

        public ObjectValidator BeLessThan(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() < value, error);
            return this;
        }

        public ObjectValidator BeNegative(string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() < 0, error);
            return this;
        }

        public ObjectValidator BePositive(string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() >= 0, error);
            return this;
        }
    }
}