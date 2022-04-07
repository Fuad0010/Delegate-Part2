using Delegate_Part2.Models;
using System;

namespace Delegate_Part2
{
        internal class User : IEntity       //User class (IEntity-ni implement edəcək)
                                            //- Username
                                            //- Email
                                            //- Role - Role enumı tipindən bir role property-i olacaq.
                                            //- ShowInfo()

    {
        public string UserName { get; set; }            
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string username, string email,string role) //ps: Username, email, role olmadan user obyekti yaratmaq olmaz
        {
            UserName = username;
            Email = email;
            Role = role;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Username: {UserName}" +
                              $"Email: {Email}" +
                              $"Role: {Role}");
        }


    }
}
