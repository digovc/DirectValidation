namespace Validation
{
    public static class StringValidatorExtensions
    {
        public static Validator<string> NotNullOrWhiteSpace(this Validator<string> validator, string error = "Invalid string value.")
        {
            if (string.IsNullOrWhiteSpace(validator.Value))
            {
                throw new ValidationException(error);
            }

            return validator;
        }
    }
}