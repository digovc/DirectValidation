using System.Text.RegularExpressions;

namespace Validation.Validators
{
    public class StringValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid string.";

        public StringValidator(string value) : base(value)
        {
        }

        public StringValidator Be(string value, string error = DefaultError)
        {
            Execute(() => GetValue<string>() == value, error);
            return this;
        }

        public StringValidator BeEmpty(string error = DefaultError)
        {
            Execute(() => GetValue<string>() == string.Empty, error);
            return this;
        }

        public StringValidator BeNullOrWhiteSpace(string error = DefaultError)
        {
            Execute(() => string.IsNullOrWhiteSpace(GetValue<string>()), error);
            return this;
        }

        public StringValidator Contain(string value, string error = DefaultError)
        {
            Execute(() => GetValue<string>()?.Contains(value) ?? false, error);
            return this;
        }

        public StringValidator EndWith(string value, string error = DefaultError)
        {
            Execute(() => GetValue<string>()?.EndsWith(value) ?? false, error);
            return this;
        }

        public StringValidator HaveLength(int length, string error = DefaultError)
        {
            Execute(() => GetValue<string>()?.Length == length, error);
            return this;
        }

        public StringValidator HaveMinLength(int length, string error = DefaultError)
        {
            Execute(() => GetValue<string>()?.Length >= length, error);
            return this;
        }

        public StringValidator Match(string pattern, string error = DefaultError)
        {
            Execute(() => Regex.IsMatch(GetValue<string>(), pattern), error);
            return this;
        }

        public StringValidator NotBe(string value, string error = DefaultError)
        {
            Execute(() => GetValue<string>() != value, error);
            return this;
        }

        public StringValidator NotBeEmpty(string error = DefaultError)
        {
            Execute(() => GetValue<string>() != string.Empty, error);
            return this;
        }

        public StringValidator NotBeNullOrWhiteSpace(string error = DefaultError)
        {
            Execute(() => !string.IsNullOrWhiteSpace(GetValue<string>()), error);
            return this;
        }

        public StringValidator NotContain(string value, string error = DefaultError)
        {
            Execute(() => !GetValue<string>()?.Contains(value) ?? false, error);
            return this;
        }

        public StringValidator NotEndWith(string value, string error = DefaultError)
        {
            Execute(() => !GetValue<string>()?.EndsWith(value) ?? false, error);
            return this;
        }

        public StringValidator NotMatch(string pattern, string error = DefaultError)
        {
            Execute(() => !Regex.IsMatch(GetValue<string>(), pattern), error);
            return this;
        }

        public StringValidator NotStartWith(string value, string error = DefaultError)
        {
            Execute(() => !GetValue<string>()?.StartsWith(value) ?? false, error);
            return this;
        }

        public StringValidator StartWith(string value, string error = DefaultError)
        {
            Execute(() => GetValue<string>()?.StartsWith(value) ?? false, error);
            return this;
        }
    }
}