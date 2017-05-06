using System;
using System.ComponentModel;

namespace OpenClosedPrinciple
{
    public class GermanyAddressVerifier: AddressVerifier
    {
        public override bool IsValidZipCode(int zipCode){
            if(zipCode < 5){
                return false;
            }
            return true;
        }
    }
}