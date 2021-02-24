using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Airport")]
    [XmlType("Airplane")]
    public class Airplane
    {
        public IBaseInfo baseInfo { get; set; }
        public ITechnicalCharacteristics technicalCharacteristics { get; set; }

        public Airplane(IAirplaneFactory airplaneFactory)
        {
            baseInfo = airplaneFactory.CreateBaseInfo();
            technicalCharacteristics = airplaneFactory.CreateTechnicalCharacteristics();
        }
    }
}
