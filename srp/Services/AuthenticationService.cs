using System;

namespace SingleResponsibilityPrinciple.Services
{
    public class AuthenticationService
    {
        public void ChangePassword(Guid accountId, string newPassword) => Console.WriteLine($"Changed password to {newPassword}");
        public void Login(string username, string password) => Console.WriteLine($"{username} has tried to log in.");
        public void Logout(string username) => Console.WriteLine($"{username} has tried to log out.");
    }
}