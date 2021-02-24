namespace OOP_Lab2
{
    public class MilitaryAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new MilitaryAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new MilitaryAirplaneTechnicalCharacteristics();
        }
    }
}
