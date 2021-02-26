namespace OOP_Lab2.AbstractFactory
{
    public class TechnicalCharacteristics : ITechnicalCharacteristics
    {
        private int carrying;
        AirplaneManufacturer airplaneManufacturer;

        public int Carrying
        {
            get => carrying;
            set => carrying = value;
        }
        public AirplaneManufacturer AirplaneManufacturer
        {
            get => airplaneManufacturer;
            set => airplaneManufacturer = value;
        }
    }
}
