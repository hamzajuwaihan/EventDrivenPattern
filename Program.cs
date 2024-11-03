using EventDrivenPattern;

var eventBus = new EventBus();
var userService = new UserService(eventBus);
var emailService = new EmailService();
var notificationService = new NotificationService();
var verificationNotificationService = new VerificationNotificationService();

// Subscribe 
eventBus.Subscribe<UserRegisteredEvent>(emailService.OnUserRegistered);
eventBus.Subscribe<UserVerifiedEvent>(verificationNotificationService.OnUserVerified);
eventBus.Subscribe<UserLoggedInEvent>(notificationService.OnUserLogIn);

//Event
userService.RegisterUser("JohnDoe", "john.doe@example.com");
//Event
userService.VerifyUser("JohnDoe", "john.doe@example.com");
//Event
userService.UserLoggedIn("JohnDoe");