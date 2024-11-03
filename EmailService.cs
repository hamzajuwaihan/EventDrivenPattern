namespace EventDrivenPattern;

public class EmailService
{
    public void OnUserRegistered(UserRegisteredEvent userRegisteredEvent)
    {
        Console.WriteLine($"Sending welcome email to {userRegisteredEvent.Email}");
    }
}
