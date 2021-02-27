using System.Collections.Generic;

namespace OOP_Lab2
{
    public class AirportInfastructureProduct
    {
        private List<Airplane> airport = new List<Airplane>();
        private Shop shop = new Shop();
        private Parking parking = new Parking();

        public List<Airplane> Airport
        {
            get => airport;
            set => airport = value;
        }

        public Shop getShop { get => shop; }
        public Shop setShop { set => shop = value; }
        public Parking getParking { get => parking; }
        public Parking setParking { set => parking = value; }

    }
}
