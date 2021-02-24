using System.Collections.Generic;

namespace OOP_Lab2.Forms
{
    public class SingletonAirport
    {
        private static SingletonAirport instance;
        private SingletonAirport() { }

        private List<Airplane> airport;

        public List<Airplane> Airport
        {
            get => airport;
            set => airport = value;
        }

        public static SingletonAirport getAirport()
        {
            if (instance == null)
                instance = new SingletonAirport();
            return instance;
        }
    }
}
