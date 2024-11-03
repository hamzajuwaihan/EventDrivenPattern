namespace EventDrivenPattern;

public class UserService(EventBus eventBus)
{
    private readonly EventBus _eventBus = eventBus;

    public void RegisterUser(string userName, string email)
    {
        var userRegisteredEvent = new UserRegisteredEvent(userName, email);
        _eventBus.Publish(userRegisteredEvent);
    }

    public void VerifyUser(string userName, string email)
    {
        var userVerifiedEvent = new UserVerifiedEvent(userName, email);
        _eventBus.Publish(userVerifiedEvent);
    }

    public void UserLoggedIn(string username){

        var UserLoggedInEvent = new UserLoggedInEvent(username);
        _eventBus.Publish(UserLoggedInEvent);
    }
}
