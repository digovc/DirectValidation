using System;

namespace Validation.Validators
{
    public class ObjectValidator
    {
        private const string DefaultError = "Invalid object.";

        private readonly object value;

        public ObjectValidator(object value)
        {
            this.value = value;
        }

        public ObjectValidator Be(object otherValue, string error = DefaultError)
        {
            Execute(() => value == otherValue, error);
            return this;
        }

        public ObjectValidator BeNull(string error = DefaultError)
        {
            Execute(() => GetValue<object>() == null, error);
            return this;
        }

        public ObjectValidator NotBe(object otherValue, string error = DefaultError)
        {
            Execute(() => value != otherValue, error);
            return this;
        }

        public ObjectValidator NotBeNull(string error = DefaultError)
        {
            Execute(() => GetValue<object>() != null, error);
            return this;
        }

        internal void Execute(Func<bool> validation, string error)
        {
            if (!validation.Invoke())
            {
                throw new ValidationException(error);
            }
        }

        protected T GetValue<T>()
        {
            if (value == null)
            {
                return default;
            }

            if (value is T)
            {
                return (T)value;
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}