using OOP_Lab2.Prototype;
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
            : base(baseInfo, technicalCharacteristics) { this.baseInfo.Type = "пассажирский"; }

        public override string PrintInfoAboutClass()
        {
            return "<--- This is PassangerAirplane --> \r\n";
        }

        public new IPrototype deepClone()
        {
            return new PassangerAirplane(base.baseInfo, base.technicalCharacteristics) as IPrototype;
        }

    }
}
