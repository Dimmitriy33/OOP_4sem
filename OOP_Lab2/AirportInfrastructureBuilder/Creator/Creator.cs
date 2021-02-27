using System.Collections.Generic;

namespace OOP_Lab2
{
    public class Creator
    {
        public string Name { get; set; }
        AirportInfastructureBuilder airportInfastructureBuilder;
        public Creator(AirportInfastructureBuilder builder) => this.airportInfastructureBuilder = builder;
        public void Create()
        {
            Name = "unknown";
            airportInfastructureBuilder.createAirport();
            airportInfastructureBuilder.createParking();
            airportInfastructureBuilder.createShop();
        }

        public void Create(List<Airplane> airplanes)
        {
            Name = "DyaDya Abramovich";
            airportInfastructureBuilder.createAirport(airplanes);
            airportInfastructureBuilder.createParking();
            airportInfastructureBuilder.createShop();
        }


    }
}
