using System;

namespace OOP_Lab2.Decorator.ConcreteDecorators
{
    [Serializable]
    public class MilitaryDecorator : AirplaneDecorator
    {
        private MilitaryDecorator() { }
        public MilitaryDecorator(Airplane airplane) : base(airplane) { }

        public override string AdditionalInfo()
        {
            return "Предназначены для решения следующих задач: отражения агрессии в" +
                " воздушно-космической сфере и защиты от ударов с воздуха пунктов" +
                " управления высших звеньев государственного и военного управления," +
                " административно-политических центров, промышленно-экономических районов," +
                " важнейших объектов экономики и инфраструктуры страны, группировок войск (сил)";
        }

    }
}
