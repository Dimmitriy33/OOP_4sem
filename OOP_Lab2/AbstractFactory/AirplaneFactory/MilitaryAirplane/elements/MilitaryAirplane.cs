using System;

namespace OOP_Lab2.AbstractFactory.AirplaneFactory.MilitaryAirplane.elements
{
    [Serializable]
    public class MilitaryAirplane : Airplane
    {
        public MilitaryAirplane()
        {

        }
        public MilitaryAirplane(BaseInfo baseInfo, TechnicalCharacteristics technicalCharacteristics)
            : base(baseInfo, technicalCharacteristics) { }

        public override string PrintInfoAboutClass()
        {
            return "<--- This is MilitaryAirplane --> \r\n";
        }
    }
}
