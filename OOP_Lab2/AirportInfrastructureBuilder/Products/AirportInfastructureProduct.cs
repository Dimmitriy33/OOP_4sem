using OOP_Lab2.Observer;
using System.Collections.Generic;

namespace OOP_Lab2
{
    public class AirportInfastructureProduct : IObservable
    {
        private List<Airplane> airport = new List<Airplane>();
        private Shop shop = new Shop();
        private Parking parking = new Parking();

        List<IObserver> observers = new List<IObserver>();

        public List<Airplane> Airport
        {
            get => airport;
            set => airport = value;
        }

        public Shop getShop { get => shop; }
        public Shop setShop { set => shop = value; }
        public Parking getParking { get => parking; }
        public Parking setParking { set => parking = value; }


        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (IObserver obs in observers)
                obs.Update(this);
        }
    }
}
