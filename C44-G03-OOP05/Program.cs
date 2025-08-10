namespace C44_G03_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            //Console.WriteLine($"Authentication: {isAuthenticated}");

            //bool isAuthorized = authService.AuthorizeUser("admin", "Admin");
            //Console.WriteLine($"Authorization: {isAuthorized}");
            #endregion

            #region Q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("yehia@gmail.com", "Welcome to our service!");
            //smsService.SendNotification("0123456789", "Your verification code is 1234.");
            //pushService.SendNotification("Yehia28", "You have a new friend request.");
            #endregion


        }
    }
}
