using System.Collections.Generic;

namespace OOP_Lab2
{
    public class MinskAirportInfastructureBuilder : AirportInfastructureBuilder
    {
        public AirportInfastructureProduct airportInfastructureProduct = new AirportInfastructureProduct();
        public override void createAirport()
        {
            airportInfastructureProduct.Airport = new List<Airplane>();
        }

        public override void createAirport(List<Airplane> airport)
        {
            airportInfastructureProduct.Airport = airport;
        }

        public override void createParking()
        {
            airportInfastructureProduct.setParking = new Parking(120);
        }

        public override void createShop()
        {
            airportInfastructureProduct.setShop = new Shop();
        }

        public override AirportInfastructureProduct getAirportInfrastructure()
        {
            return airportInfastructureProduct;
        }
    }
}
