using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    //Refactor this code to by using DIP principle

    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Send email example
            Console.WriteLine($"Sending email to {to}: {subject}");
        }
    }

    public class UserNotification
    {
        private EmailService _emailService;

        public UserNotification()
        {
            _emailService = new EmailService();
        }

        public void NotifyUser(string email)
        {
            _emailService.SendEmail(email, "Welcome", "Welcome to our service!");
        }
    }

    public class DIPAssignmentTest
    {
        public void Test()
        {
            UserNotification notification = new UserNotification();
            notification.NotifyUser("");
        }
    }
}
