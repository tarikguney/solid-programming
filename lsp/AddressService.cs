using System;
using System.ComponentModel;

namespace LiskovsSubsitutionPrinciple
{
    public class AddressService{
        protected const int USZipCodeBase = 1000;
        
        public virtual Address GetAddressForUser(int userId){
            Require.That(()=> userId > 10);
            // Getting it from a service...
            var address = new Address(){
                Street = "Test Street",
                ZipCode = 24509,
                City = "Murray",
                State = "New England",
                Country = "USA"
            };
            Require.That(() => address.ZipCode > 1000);
            return address;
        }
    }
}