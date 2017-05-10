namespace InterfaceSegregationPrinciple
{
    public interface IAnimal: IOmnivore
    {
        void Bark();
        void Walk();
        void Sleep();
        void Run();
        void Bite();
    }
}