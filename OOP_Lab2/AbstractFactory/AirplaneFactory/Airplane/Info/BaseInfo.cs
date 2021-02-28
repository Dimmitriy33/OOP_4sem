using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OOP_Lab2.AbstractFactory
{
    [Serializable]
    public class BaseInfo : IBaseInfo
    {
        private int id;
        private string type;
        private string model;
        private List<CrewMember> crewMembers = new List<CrewMember>();
        private int numberOfPassengers;
        private int yearOfIssue;
        private DateTime dateOfTheLatestMaintenance;

        [XmlElement(ElementName = "id")]
        public int ID
        {
            get => id;
            set => id = value;
        }

        [XmlElement(ElementName = "type")]
        public string Type
        {
            get => type;
            set => type = value;
        }

        [XmlElement(ElementName = "model")]
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

        [XmlElement(ElementName = "Date", DataType = "date")]
        public DateTime DateOfTheLatestMaintenance
        {
            get => dateOfTheLatestMaintenance;
            set => dateOfTheLatestMaintenance = value;
        }

        public string PrintInfoAboutClass()
        {
            return "unknown";
        }
    }
}
