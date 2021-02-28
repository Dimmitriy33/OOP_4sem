using System.Collections.Generic;

namespace OOP_Lab2
{
    public abstract class AirportInfastructureBuilder
    {
        public abstract void createAirport();
        public abstract void createAirport(List<Airplane> airplanes);
        public abstract void createShop();
        public abstract void createShop(Shop shop);
        public abstract void createParking();
        public abstract void createParking(Parking parking);
        public abstract AirportInfastructureProduct getAirportInfrastructure();
    }
}
