using System;

namespace SingleResponsibilityPrinciple.Services
{
    public class AddressService
    {
        public void ChangeAddress(Guid accountId, Address newAddress) => Console.WriteLine("Changed address");
    }
}