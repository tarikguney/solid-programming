using System;
using OpenClosedPrinciple;

namespace ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateFinder = new StateFinder();
            try{
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9));
            } catch(InvalidOperationException exception){
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
