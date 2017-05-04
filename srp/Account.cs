using System;

namespace SingleResponsibilityPrinciple
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City{get;set;}
        public Guid AccountId {get;set;}
        public string Password {get;set;}
        public string Username {get;set;}
        
        public void ChangePassword(string newPassword) => Console.WriteLine($"Changed password to {newPassword}");
        public void ChangeAddress(string street, int zipCode, string city) => Console.WriteLine("Changed address");
        public string GetAccountHolderFirstName(Guid accountNumber) => this.FirstName;
        public string GetAccountHolderLastName(Guid accountNumber) => this.LastName;
        public void DepositMoney(decimal amount) => Console.WriteLine($"{amount} has been deposited to {this.AccountId}");
        public void WithdrawMoney(decimal amount) => Console.WriteLine($"{amount} has been withdrawn from {this.AccountId}");
        public void Login(string username, string password) => Console.WriteLine($"{username} has tried to log in.");
        public void Logout(string username) => Console.WriteLine($"{username} has tried to log out.");
    }
}