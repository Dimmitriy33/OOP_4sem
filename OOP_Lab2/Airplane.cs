using OOP_Lab2.AbstractFactory;
using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{

    [Serializable]
    [XmlInclude(typeof(CargoAirplaneFactory))]
    [XmlInclude(typeof(MilitaryAirplaneFactory))]
    [XmlInclude(typeof(PassangerAirplaneFactory))]
    public abstract class Airplane
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
    }
}
