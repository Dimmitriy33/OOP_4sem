namespace OOP_Lab2
{
    public class CargoAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new CargoAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new CargoAirplaneTechnicalCharacteristics();
        }
    }
}
