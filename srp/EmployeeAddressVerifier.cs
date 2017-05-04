using System;

namespace SingleResponsibilityPrinciple
{
    public class EmployeeAddressVerifier{
        public bool IsAddressValid(EmployeeAccount account){
            // NEW CODE -- Check country is in the supported countries.
            // For employees, we are using the internal system to check if their addresses are valid.
            return true;
        }
    }
}