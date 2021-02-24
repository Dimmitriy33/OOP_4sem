using System;

namespace OOP_Lab2
{
    [Serializable]
    public class Airplane
    {
        public IBaseInfo baseInfo { get; set; }
        public ITechnicalCharacteristics technicalCharacteristics { get; set; }
        public Airplane()
        {

        }

        public Airplane(IAirplaneFactory airplaneFactory)
        {
            baseInfo = airplaneFactory.CreateBaseInfo();
            technicalCharacteristics = airplaneFactory.CreateTechnicalCharacteristics();
        }
    }
}
