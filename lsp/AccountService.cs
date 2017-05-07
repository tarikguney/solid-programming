using System;

namespace LiskovsSubsitutionPrinciple
{
    public class AccountService
    {
        public void ChangeAddress(Address address){
            Require.That(()=> address.ZipCode > 1000);
            // .. Save the address.
            Console.WriteLine("Account address has been changed succesfully");
        }
    }
}