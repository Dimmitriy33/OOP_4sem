using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Airport")]
    [XmlType("Airplane")]
    public class MilitaryAirplaneFactory : IAirplaneFactory
    {
        public IBaseInfo CreateBaseInfo()
        {
            return new MilitaryAirplaneBaseInfo();
        }

        public ITechnicalCharacteristics CreateTechnicalCharacteristics()
        {
            return new MilitaryAirplaneTechnicalCharacteristics();
        }
    }
}
