using System;

namespace OpenClosedPrinciple
{
    public class StateFinder
    {
        public string GetStateNameForZipCode(int zipCode, AddressVerifier verifier)
        {
            if(!verifier.IsValidZipCode(zipCode)){
                throw new InvalidOperationException($"Invalid ZipCode: {zipCode}");
            }

            switch(zipCode){
                case 9:
                    return "Munih";
                case 10:
                    return "Berlin";
                case 11:
                    return "California";
                case 12:
                    return "Utah";
                default:
                    throw new InvalidOperationException($"No state is found with {zipCode}");
            }
        }
    }
}