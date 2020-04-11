using System;

namespace Validation.Validators
{
    public class DateTimeValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid date.";

        public DateTimeValidator(DateTime value) : base(value)
        {
        }

        public DateTimeValidator Be(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() == value, error);
            return this;
        }

        public DateTimeValidator BeAfter(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() > value, error);
            return this;
        }

        public DateTimeValidator BeBefore(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() < value, error);
            return this;
        }

        public DateTimeValidator BeOnOrAfter(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() >= value, error);
            return this;
        }

        public DateTimeValidator BeOnOrBefore(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() <= value, error);
            return this;
        }

        public DateTimeValidator BeSameDateAs(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>().ToString("yyyy/MM/dd") == value.ToString("yyyy/MM/dd"), error);
            return this;
        }

        public DateTimeValidator NotBe(DateTime value, string error = DefaultError)
        {
            Execute(() => GetValue<DateTime>() != value, error);
            return this;
        }
    }
}