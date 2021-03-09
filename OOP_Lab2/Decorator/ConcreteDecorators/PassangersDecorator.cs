using System;

namespace OOP_Lab2.Decorator.ConcreteDecorators
{
    [Serializable]
    public class PassangersDecorator : AirplaneDecorator
    {
        private PassangersDecorator() { }

        public PassangersDecorator(Airplane airplane) : base(airplane) { }

        public override string AdditionalInfo()
        {
            return "самолёт, предназначенный и оборудованный для перевозки пассажиров и багажа." +
                " В отличие от многоцелевых транспортных самолетов, пассажирские самолёты имеют" +
                " раздельные отсеки для перевозки людей и груза, или не имеют дополнительного грузового отсека вовсе";
        }
    }
}
