using System;

namespace OpenClosedPrinciple
{
    public class StateFinder
    {
        public string GetStateNameForZipCode(int zipCode)
        {
            if(!AddressVerifier.IsValidZipCode(zipCode)){
                throw new InvalidOperationException($"Invalid ZipCode: {zipCode}");
            }

            switch(zipCode){
                case 11:
                    return "California";
                case 12:
                    return "Utah";
                default:
                    throw new InvalidCastException($"No state is found with {zipCode}");
            }
        }
    }
}