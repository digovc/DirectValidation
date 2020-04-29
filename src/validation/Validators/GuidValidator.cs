using System;

namespace Validation.Validators
{
    public class GuidValidator : ObjectValidator
    {
        private const string DefaultError = "Invalid boolean.";

        public GuidValidator(Guid value) : base(value)
        {
        }

        public GuidValidator BeEmpty(string error = DefaultError, params object[] args)
        {
            Execute(() => Guid.Empty.Equals(GetValue<Guid>()), error, args);
            return this;
        }

        public GuidValidator NotBeEmpty(string error = DefaultError, params object[] args)
        {
            Execute(() => !Guid.Empty.Equals(GetValue<Guid>()), error, args);
            return this;
        }
    }
}