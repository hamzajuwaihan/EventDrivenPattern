namespace EventDrivenPattern;

public class NotificationService
{

    public void OnUserLogIn(UserLoggedInEvent userLoggedInEvent)
    {
        Console.WriteLine($"Hi {userLoggedInEvent.UserName}, you logged in at {userLoggedInEvent.TimeStamp}");
    }
}
