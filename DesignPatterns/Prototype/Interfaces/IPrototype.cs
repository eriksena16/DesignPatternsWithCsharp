namespace DesignPatterns.Prototype.Interfaces
{
    public interface IPrototype<T>
    {
        T Clone();
        void DisplayInfo();
    }

}
