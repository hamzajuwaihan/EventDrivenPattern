using System;

namespace EventDrivenPattern;

public class UserVerifiedEvent(string userName, string email)
{
    public string UserName { get; } = userName;
    public string Email { get; } = email;
}
