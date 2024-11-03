using System;

namespace EventDrivenPattern;

public class VerificationNotificationService
{
    public void OnUserVerified(UserVerifiedEvent userVerifiedEvent)
    {
        Console.WriteLine($"User {userVerifiedEvent.UserName} has been verified.");
    }
}
