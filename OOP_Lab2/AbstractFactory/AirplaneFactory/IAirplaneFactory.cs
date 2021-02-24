namespace OOP_Lab2
{
    public interface IAirplaneFactory
    {
        IBaseInfo CreateBaseInfo();
        ITechnicalCharacteristics CreateTechnicalCharacteristics();
    }
}
