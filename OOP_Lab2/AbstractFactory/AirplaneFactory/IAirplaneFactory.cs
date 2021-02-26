using OOP_Lab2.AbstractFactory;

namespace OOP_Lab2
{
    public abstract class IAirplaneFactory
    {
        public abstract Airplane CreateAirplane();
        public abstract Airplane CreateAirplane(BaseInfo baseinfo, TechnicalCharacteristics technicalCharacteristics);
    }
}
