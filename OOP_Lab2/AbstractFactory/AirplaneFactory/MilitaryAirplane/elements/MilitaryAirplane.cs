using OOP_Lab2.Prototype;
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
            : base(baseInfo, technicalCharacteristics) { this.baseInfo.Type = "военный"; }


        public override string PrintInfoAboutClass()
        {
            return "<--- This is MilitaryAirplane --> \r\n";
        }

        public new IPrototype deepClone()
        {
            return new MilitaryAirplane(base.baseInfo, base.technicalCharacteristics) as IPrototype;
        }

    }
}
