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
    }
}