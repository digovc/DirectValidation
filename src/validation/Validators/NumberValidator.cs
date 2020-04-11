namespace Validation.Validators
{
    public class NumberValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid number.";

        public NumberValidator(decimal value) : base(value)
        {
        }

        public NumberValidator Be(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() == value, error, args);
            return this;
        }

        public NumberValidator BeBetween(decimal minValue, decimal maxValue, string error = DefaultError, params object[] args)
        {
            var value = GetValue<decimal>();
            Execute(() => value > minValue && value < maxValue, error, args);
            return this;
        }

        public NumberValidator BeBetweenOrEqualTo(decimal minValue, decimal maxValue, string error = DefaultError, params object[] args)
        {
            var value = GetValue<decimal>();
            Execute(() => value >= minValue && value <= maxValue, error, args);
            return this;
        }

        public NumberValidator BeGreaterOrEqualTo(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() >= value, error, args);
            return this;
        }

        public NumberValidator BeGreaterThan(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() > value, error, args);
            return this;
        }

        public NumberValidator BeLessOrEqualTo(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() <= value, error, args);
            return this;
        }

        public NumberValidator BeLessThan(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() < value, error, args);
            return this;
        }

        public NumberValidator BeNegative(string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() < 0, error, args);
            return this;
        }

        public NumberValidator BePositive(string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() >= 0, error, args);
            return this;
        }

        public NumberValidator NotBe(decimal value, string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<decimal>() != value, error, args);
            return this;
        }
    }
}