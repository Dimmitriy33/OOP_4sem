using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace OOP_Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Airport")]
    [XmlType("Airplane")]
    public class Airplane
    {
        private int id;
        private string type;
        private string model;
        private List<CrewMember> crewMembers = new List<CrewMember>();
        private int numberOfPassengers;
        private int yearOfIssue;
        private int carrying;
        private AirplaneManufacturer manufacturer = new AirplaneManufacturer();
        private DateTime dateOfTheLatestMaintenance;

        public Airplane()
        {

        }
        [XmlElement(ElementName = "id")]
        [My]
        public int ID
        {
            get => id;
            set => id = value;
        }

        [XmlElement(ElementName = "type")]
        [Required(ErrorMessage = "Pls choose type")]
        public string Type
        {
            get => type;
            set => type = value;
        }

        [XmlElement(ElementName = "model")]
        [RegularExpression(@"((([a-zA-Zа-яА-ЯёЁ]+\d+)|(\d+[a-zA-Zа-яА-ЯёЁ]+))[a-zA-Zа-яА-ЯёЁ\d]*)",
            ErrorMessage = "Invalid value of model")]
        public string Model
        {
            get => model;
            set => model = value;
        }

        [XmlArray("crewmembers")]
        [XmlArrayItem("cewmember")]
        public List<CrewMember> CrewMembers
        {
            get => crewMembers;
            set => crewMembers = value;
        }

        [XmlElement(ElementName = "numberofpassenges")]
        public int NumberOfPassengers
        {
            get => numberOfPassengers;
            set => numberOfPassengers = value;
        }


        [XmlElement(ElementName = "yearofissue")]
        public int YearOfIssue
        {
            get => yearOfIssue;
            set => yearOfIssue = value;
        }

        [XmlElement(ElementName = "carrying")]
        public int Carrying
        {
            get => carrying;
            set => carrying = value;
        }

        [XmlElement(ElementName = "Date", DataType = "date")]
        public DateTime DateOfTheLatestMaintenance
        {
            get => dateOfTheLatestMaintenance;
            set => dateOfTheLatestMaintenance = value;
        }

        [XmlElement(ElementName = "manufacturer")]
        public AirplaneManufacturer AirplaneManufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
    }
}
