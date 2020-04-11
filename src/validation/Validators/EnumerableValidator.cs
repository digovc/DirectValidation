using System.Collections.Generic;
using System.Linq;

namespace Validation.Validators
{
    public class EnumerableValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid enumerable.";
        private readonly IEnumerable<object> values;

        public EnumerableValidator(IEnumerable<object> value) : base(value)
        {
            values = value;
        }

        public EnumerableValidator BeEmpty(string error = DefaultError)
        {
            Execute(() => (values?.Count() ?? -1) == 0, error);
            return this;
        }

        public EnumerableValidator BeNullOrEmpty(string error = DefaultError)
        {
            Execute(() => (values?.Count() ?? 0) == 0, error);
            return this;
        }

        public EnumerableValidator HaveCount(int count, string error = DefaultError)
        {
            Execute(() => values?.Count() == count, error);
            return this;
        }

        public EnumerableValidator HaveCountGreaterOrEqualTo(int count, string error = DefaultError)
        {
            Execute(() => values?.Count() >= count, error);
            return this;
        }

        public EnumerableValidator HaveCountGreaterThan(int count, string error = DefaultError)
        {
            Execute(() => values?.Count() > count, error);
            return this;
        }

        public EnumerableValidator HaveCountLessOrEqualTo(int count, string error = DefaultError)
        {
            Execute(() => values?.Count() <= count, error);
            return this;
        }

        public EnumerableValidator HaveCountLessThan(int count, string error = DefaultError)
        {
            Execute(() => values?.Count() < count, error);
            return this;
        }

        public EnumerableValidator NotBeEmpty(string error = DefaultError)
        {
            Execute(() => values?.Count() > 0, error);
            return this;
        }

        public EnumerableValidator NotBeNullOrEmpty(string error = DefaultError)
        {
            Execute(() => (values?.Count() ?? -1) > 0, error);
            return this;
        }
    }
}