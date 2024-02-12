using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    //Refactor this code to by using DRY principle

    public class UserRegistration
    {
        public bool Register(string email, string password)
        {
            if (!email.Contains("@"))
            {
                return false;
            }

            return true;
        }
    }

    public class PasswordReset
    {
        public bool SendPasswordResetEmail(string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }

            return true;
        }
    }
}
