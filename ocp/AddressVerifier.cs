using System;
using System.ComponentModel;

namespace OpenClosedPrinciple
{
    public class AddressVerifier
    {
        public virtual bool IsAddressValid(Address address){
           return true; 
        }

        public virtual bool IsValidZipCode(int zipCode){
            if(zipCode < 10){
                return false;
            }
            return true;
        }
    }
}