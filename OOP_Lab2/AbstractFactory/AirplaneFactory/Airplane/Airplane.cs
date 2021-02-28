using OOP_Lab2.AbstractFactory;
using OOP_Lab2.AbstractFactory.AirplaneFactory.CargoAirplane.elements;
using OOP_Lab2.AbstractFactory.AirplaneFactory.MilitaryAirplane.elements;
using OOP_Lab2.AbstractFactory.AirplaneFactory.PassangerAirplane.elements;
using OOP_Lab2.Prototype;
using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{

    [Serializable]
    [XmlInclude(typeof(CargoAirplane))]
    [XmlInclude(typeof(MilitaryAirplane))]
    [XmlInclude(typeof(PassangerAirplane))]
    public abstract class Airplane : IPrototype
    {

        public BaseInfo baseInfo { get; set; }
        public TechnicalCharacteristics technicalCharacteristics { get; set; }
        public Airplane()
        {
            baseInfo = new BaseInfo();
            technicalCharacteristics = new TechnicalCharacteristics();
        }

        public Airplane(BaseInfo baseInfo, TechnicalCharacteristics technicalCharacteristics)
        {
            this.baseInfo = baseInfo;
            this.technicalCharacteristics = technicalCharacteristics;
        }

        public abstract string PrintInfoAboutClass();

        public IPrototype shallowClone()
        {
            return this.MemberwiseClone() as IPrototype;
        }

        public IPrototype deepClone()
        {
            Airplane clone = (Airplane)this.MemberwiseClone();
            clone.baseInfo = this.baseInfo;
            clone.technicalCharacteristics = this.technicalCharacteristics;
            return clone as IPrototype;
        }
    }
}
