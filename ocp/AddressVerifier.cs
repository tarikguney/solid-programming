using System;
using System.ComponentModel;

namespace OpenClosedPrinciple
{
    public class AddressVerifier
    {
        public static bool IsAddressValid(Address address){
           return true; 
        }

        public static bool IsValidZipCode(int zipCode){
            if(zipCode < 5){
                return false;
            }
            return true;
        }
    }
}