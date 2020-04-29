# DirectValidation

A simple library write in ,NET (C#) to validate your staff without nesting your code.

```csharp
using Validation;

object myValue = null;
myValue.Validate().NotBeNull("This fail because myValue is null.");
```

This library is inspired by two great libraries: [FluentValidation](https://fluentvalidation.net/) and [FluentAssertions](https://fluentassertions.com/).

With **DirectValidation** you can use a simple and direct code style to validate your variables, properties, etc, without worry about nesting your code with _if, else_. Just call your validation directly.

We use the _fail first_ design. This means that if your validation don't pass a exception are thrown immediately:

```csharp
using Validation;

var myValue = "foo";
myValue.Validate().Be("bar", "myValue is not foo.");
```

### Get Started

**DirectValidation** can be installed using the Nuget package manager or the `dotnet` CLI.

```
Install-Package DirectValidation
```

### Example

Just add _Validation_ to your using list and call _Validate()_ method in any type of value to access the validation methods.

```csharp
using Validation;

var myValue = "foo";
myValue.Validate().NotBeNullOrWhiteSpace().NotBe("bar").Be("foo"); // etc
```

All validation methods receives a _message_ and an _args_ parameters to format your fail message using _string.format()_.

Every type has your own validations, a bunch of that, I put the most commons. If your feel some other is missing, just send a PR to this repository, I appreciate.

I implement most validations found in [FluentValidation](https://fluentvalidation.net/) and [FluentAssertions](https://fluentassertions.com/), so you can found there what I talk about.

### License

DirectValidation has adopted **Apache License**, so you can use this freely to all purpose.
