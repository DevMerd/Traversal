﻿using Microsoft.AspNetCore.Identity;

namespace Traversal.WebUI.Validation
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karakter olmalıdır"
            };
        }
    }
}
