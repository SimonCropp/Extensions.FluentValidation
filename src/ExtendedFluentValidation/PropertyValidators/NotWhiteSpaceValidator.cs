﻿namespace ExtendedFluentValidation;

public class NotWhiteSpaceValidator<T> :
    PropertyValidator<T, string?>
{
    public override string Name => "NotWhiteSpaceValidator";

    public override bool IsValid(ValidationContext<T> context, string? value)
    {
        if (value == null)
        {
            return true;
        }

        return !string.IsNullOrWhiteSpace(value);
    }

    protected override string GetDefaultMessageTemplate(string errorCode) =>
        "'{PropertyName}' must not be whitespace.";
}