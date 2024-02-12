using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesAssignment
{
    //Refactor this code to by using SRP principle
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public void Save()
        {
            Console.WriteLine($"Saving user {Name} with email {Email} to the database.");
            // Imagine that in here users data is saved to db
        }

        public void Test()
        {
            User user = new User("John", "test");

            user.Save();
        }
    }

   
}
