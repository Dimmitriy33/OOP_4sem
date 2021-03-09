using System;

namespace OOP_Lab2.Decorator
{
    [Serializable]
    public class CargoDecorator : AirplaneDecorator
    {
        private CargoDecorator() { }
        public CargoDecorator(Airplane airplane) : base(airplane) { }

        public override string AdditionalInfo()
        {
            return " самолёт, предназначенный для транспортировки различных грузов." +
                " Часто один и тот же самолёт бывает грузовым и пассажирским, изменяется только оборудование. ";
        }

    }
}
