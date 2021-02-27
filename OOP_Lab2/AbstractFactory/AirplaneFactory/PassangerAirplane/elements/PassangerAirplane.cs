using System;

namespace OOP_Lab2.AbstractFactory.AirplaneFactory.PassangerAirplane.elements
{
    [Serializable]
    public class PassangerAirplane : Airplane
    {
        public PassangerAirplane()
        {

        }

        public PassangerAirplane(BaseInfo baseInfo, TechnicalCharacteristics technicalCharacteristics)
            : base(baseInfo, technicalCharacteristics) { }

        public override string PrintInfoAboutClass()
        {
            return "<--- This is PassangerAirplane --> \r\n";
        }
    }
}
