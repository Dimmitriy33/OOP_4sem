using OOP_Lab2.Prototype;
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
            : base(baseInfo, technicalCharacteristics) { this.baseInfo.Type = "грузовой"; }

        public override string PrintInfoAboutClass()
        {
            return "<--- This is CargoAirplane --> \r\n";
        }

        public new IPrototype deepClone()
        {
            return new CargoAirplane(base.baseInfo, base.technicalCharacteristics) as IPrototype;
        }

    }
}
