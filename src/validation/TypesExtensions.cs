﻿using System;
using System.Collections.Generic;
using Validation.Validators;

namespace Validation
{
    public static class TypesExtensions
    {
        public static EnumValidator Validate(this Enum value) => new EnumValidator(value);

        public static ObjectValidator Validate(this object value) => new ObjectValidator(value);

        public static BooleanValidator Validate(this bool value) => new BooleanValidator(value);

        public static DateTimeValidator Validate(this DateTime value) => new DateTimeValidator(value);

        public static NumberValidator Validate(this decimal value) => new NumberValidator(value);

        public static NumberValidator Validate(this float value) => new NumberValidator((decimal)value);

        public static NumberValidator Validate(this double value) => new NumberValidator((decimal)value);

        public static NumberValidator Validate(this int value) => new NumberValidator(value);

        public static NumberValidator Validate(this uint value) => new NumberValidator(value);

        public static NumberValidator Validate(this long value) => new NumberValidator(value);

        public static NumberValidator Validate(this ulong value) => new NumberValidator(value);

        public static NumberValidator Validate(this short value) => new NumberValidator(value);

        public static NumberValidator Validate(this ushort value) => new NumberValidator(value);

        public static StringValidator Validate(this string value) => new StringValidator(value);

        public static GuidValidator Validate(this Guid value) => new GuidValidator(value);

        public static EnumerableValidator Validate(this IEnumerable<object> value) => new EnumerableValidator(value);
    }
}