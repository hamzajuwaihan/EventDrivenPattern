namespace EventDrivenPattern;

public class UserLoggedInEvent(string userName)
{
    public string UserName { get; } = userName;
    public DateTime TimeStamp { get; } = DateTime.UtcNow;
}
