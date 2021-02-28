using System;
using System.Xml.Serialization;

namespace OOP_Lab2.AbstractFactory
{
    [Serializable]
    public class TechnicalCharacteristics : ITechnicalCharacteristics
    {
        private int carrying;
        AirplaneManufacturer airplaneManufacturer;

        [XmlElement(ElementName = "Carrying")]
        public int Carrying
        {
            get => carrying;
            set => carrying = value;
        }

        [XmlElement(ElementName = "Manufacturer")]
        public AirplaneManufacturer AirplaneManufacturer
        {
            get => airplaneManufacturer;
            set => airplaneManufacturer = value;
        }
    }
}
