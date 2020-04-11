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

        public ObjectValidator Be(object otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => value == otherValue, error, args);
            return this;
        }

        public ObjectValidator BeNull(string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<object>() == null, error, args);
            return this;
        }

        public ObjectValidator NotBe(object otherValue, string error = DefaultError, params object[] args)
        {
            Execute(() => value != otherValue, error, args);
            return this;
        }

        public ObjectValidator NotBeNull(string error = DefaultError, params object[] args)
        {
            Execute(() => GetValue<object>() != null, error, args);
            return this;
        }

        internal void Execute(Func<bool> validation, string error, params object[] args)
        {
            if (!validation.Invoke())
            {
                Fail(error, args);
            }
        }

        protected static void Fail(string error, object[] args)
        {
            throw new ValidationException(string.Format(error, args));
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