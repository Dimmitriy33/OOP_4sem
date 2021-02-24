using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Airport")]
    [XmlType("Airplane")]
    public class PassangerAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new PassangerAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new PassangerAirplaneTechnicalCharacteristics();
        }
    }
}
