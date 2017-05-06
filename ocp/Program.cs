using System;
using OpenClosedPrinciple;

namespace ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateFinder = new StateFinder();

            // For the United States
            try{
                var addressVerifier = new AddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11, addressVerifier));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
            } catch(InvalidOperationException exception){
                Console.WriteLine(exception.Message);
            }
            
            // For the Germany
            try{
                var addressVerifier = new GermanyAddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
            } catch(InvalidOperationException exception){
                Console.WriteLine(exception.Message);
            }
        }
    }
}
