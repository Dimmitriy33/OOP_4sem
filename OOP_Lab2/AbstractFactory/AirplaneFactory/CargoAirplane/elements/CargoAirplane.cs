using System;

namespace OOP_Lab2.AbstractFactory.AirplaneFactory.CargoAirplane.elements
{
    [Serializable]
    public class CargoAirplane : Airplane
    {
        public CargoAirplane()
        {

        }
        public CargoAirplane(BaseInfo baseInfo, TechnicalCharacteristics technicalCharacteristics)
            : base(baseInfo, technicalCharacteristics) { }

        public override string PrintInfoAboutClass()
        {
            return "<--- This is CargoAirplane --> \r\n";
        }
    }
}
