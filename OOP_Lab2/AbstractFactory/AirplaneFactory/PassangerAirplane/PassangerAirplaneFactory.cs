using OOP_Lab2.AbstractFactory;
using OOP_Lab2.AbstractFactory.AirplaneFactory.PassangerAirplane.elements;

namespace OOP_Lab2
{
    public class PassangerAirplaneFactory : IAirplaneFactory
    {
        public override Airplane CreateAirplane(BaseInfo baseinfo, TechnicalCharacteristics technicalCharacteristics)
        {
            return new PassangerAirplane(baseinfo, technicalCharacteristics);
        }

        public override Airplane CreateAirplane()
        {
            return new PassangerAirplane();
        }
    }
}
