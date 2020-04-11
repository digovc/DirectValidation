namespace Validation
{
    public class Validator<T>
    {
        public T Value
        {
            get; set;
        }

        public Validator(T value)
        {
            Value = value;
        }
    }
}