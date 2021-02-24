namespace OOP_Lab2
{
    public class PassangerAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new PassangerAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new PassangerAirplaneTechnicalCharacteristics();
        }
    }
}
