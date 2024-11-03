namespace EventDrivenPattern;

public class UserRegisteredEvent(string userName, string email)
{
    public string UserName { get; } = userName;
    public string Email { get; } = email;
}
