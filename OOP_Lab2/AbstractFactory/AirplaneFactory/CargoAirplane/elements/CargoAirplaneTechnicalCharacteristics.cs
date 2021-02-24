using System;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    public class CargoAirplaneTechnicalCharacteristics : ITechnicalCharacteristics
    {
        private int carrying;
        private AirplaneManufacturer manufacturer = new AirplaneManufacturer();

        [XmlElement(ElementName = "carrying")]
        public int Carrying
        {
            get => carrying;
            set => carrying = value;
        }

        [XmlElement(ElementName = "manufacturer")]
        public AirplaneManufacturer AirplaneManufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
    }
}
