namespace Validation
{
    public static class TypesExtensions
    {
        public static Validator<string> Validate(this string value)
        {
            return new Validator<string>(value);
        }
    }
}