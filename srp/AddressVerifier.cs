using System;
using System.ComponentModel;

namespace SingleResponsibilityPrinciple
{
    public class AddressVerifier{
        public bool IsAddressValid(Address address, AddressTypeEnum addressType){
            // You can change this class to AddressVerifierFactory to generate a class based on addressType, etc.
            // or simply say the following
            switch (addressType)
            {
                case AddressTypeEnum.Customer:
                // Customer address check
                break;
                case AddressTypeEnum.Employee:
                // Employee..
                default:
                throw new InvalidOperationException();            
            }
            return true;
        }
    }
}