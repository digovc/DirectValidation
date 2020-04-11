using System;

namespace Validation
{
    [Serializable]
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}