namespace OOP_Lab2.Prototype
{
    public interface IPrototype
    {
        IPrototype shallowClone();
        IPrototype deepClone();
    }
}
