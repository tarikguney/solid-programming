using System;
using LiskovsSubsitutionPrinciple;

namespace lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressService = new NewAddressService();
            var address = addressService.GetAddressForUser(25);
            var accountService = new AccountService();
            accountService.ChangeAddress(address);
        }
    }
}
