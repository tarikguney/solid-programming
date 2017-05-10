using System;

namespace InterfaceSegregationPrinciple
{
    public class FoodBank
    {
        // I don't just need humans. The food bank may provide food to
        // animals too.
        public void AddToList(IHuman human)
        {
            throw new NotImplementedException();
        }

        // This does not look right!
        public void AddToList(IAnimal animal)
        {
            throw new NotImplementedException();
        }

        // The question is what exactly I need. I need anything that can eat.
    }
}