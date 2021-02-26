using OOP_Lab2.AbstractFactory;
using OOP_Lab2.AbstractFactory.AirplaneFactory.CargoAirplane.elements;

namespace OOP_Lab2
{
    public class CargoAirplaneFactory : IAirplaneFactory
    {
        public override Airplane CreateAirplane(BaseInfo baseinfo, TechnicalCharacteristics technicalCharacteristics)
        {
            return new CargoAirplane(baseinfo, technicalCharacteristics);
        }

        public override Airplane CreateAirplane()
        {
            return new CargoAirplane();
        }
    }
}
