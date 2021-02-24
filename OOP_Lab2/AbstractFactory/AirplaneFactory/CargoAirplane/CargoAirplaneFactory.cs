using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Airport")]
    [XmlType("Airplane")]
    public class CargoAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new CargoAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new CargoAirplaneTechnicalCharacteristics();
        }
    }
}
