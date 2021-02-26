using OOP_Lab2.AbstractFactory;
using OOP_Lab2.AbstractFactory.AirplaneFactory.MilitaryAirplane.elements;

namespace OOP_Lab2
{
    public class MilitaryAirplaneFactory : IAirplaneFactory
    {
        public override Airplane CreateAirplane(BaseInfo baseinfo, TechnicalCharacteristics technicalCharacteristics)
        {
            return new MilitaryAirplane(baseinfo, technicalCharacteristics);
        }

        public override Airplane CreateAirplane()
        {
            return new MilitaryAirplane();
        }
    }
}
