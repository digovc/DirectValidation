namespace Validation.Validators
{
    public class NumberValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid number.";

        public NumberValidator(decimal value) : base(value)
        {
        }

        public NumberValidator Be(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() == value, error);
            return this;
        }

        public NumberValidator BeGreaterOrEqualTo(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() >= value, error);
            return this;
        }

        public NumberValidator BeGreaterThan(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() > value, error);
            return this;
        }

        public NumberValidator BeLessOrEqualTo(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() <= value, error);
            return this;
        }

        public NumberValidator BeLessThan(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() < value, error);
            return this;
        }

        public NumberValidator BeNegative(string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() < 0, error);
            return this;
        }

        public NumberValidator BePositive(string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() >= 0, error);
            return this;
        }

        public NumberValidator NotBe(decimal value, string error = DefaultError)
        {
            Execute(() => GetValue<decimal>() != value, error);
            return this;
        }
    }
}