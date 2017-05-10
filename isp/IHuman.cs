namespace InterfaceSegregationPrinciple
{
    public interface IHuman : IOmnivore
    {
        void Talk();
        void Walk();
        void Sleep();
        void Run();
    }
}