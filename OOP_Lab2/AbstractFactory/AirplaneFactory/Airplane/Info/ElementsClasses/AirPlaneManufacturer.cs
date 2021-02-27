using System;
using System.Collections.Generic;

namespace OOP_Lab2
{
    [Serializable]
    public class AirplaneManufacturer
    {
        private string name;
        private string country;
        private int yearOfFoundation;
        private List<string> typesOfAircraft = new List<string>();

        public AirplaneManufacturer()
        {

        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public int YearOfFoundation
        {
            get => yearOfFoundation;
            set => yearOfFoundation = value;
        }

        public List<string> TypesOfAircraft
        {
            get => typesOfAircraft;
            set => typesOfAircraft = value;
        }
    }
}
