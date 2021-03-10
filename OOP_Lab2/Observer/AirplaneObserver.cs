using System.Windows.Forms;

namespace OOP_Lab2.Observer
{
    public class AirplaneObserver : IObserver
    {
        public void Update(IObservable observable)
        {
            if ((observable as AirportInfastructureProduct).Airport.Count > 0)
                MessageBox.Show($"added {(observable as AirportInfastructureProduct).Airport.Count} airplane to the airport");
            // исходя из логики тут должно отправляться сообщение observer-у
        }
    }
}
