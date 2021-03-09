using System;

namespace OOP_Lab2.Decorator
{
    [Serializable]
    public abstract class AirplaneDecorator : Airplane, IAdditionalInfo
    {
        private string s;
        [NonSerialized]
        private IAdditionalInfo _additionalInfo;

        public AirplaneDecorator() { }

        public AirplaneDecorator(Airplane airplane)
            : base(baseInfo: airplane.baseInfo, technicalCharacteristics: airplane.technicalCharacteristics)
        {
            s = airplane.PrintInfoAboutClass();
        }

        public override string PrintInfoAboutClass()
        {
            return this.s;
        }

        public void setAdditionalInfo(IAdditionalInfo additionalInfo)
        {
            this._additionalInfo = additionalInfo;
        }
        public virtual string AdditionalInfo()
        {
            if (this._additionalInfo != null)
                return this._additionalInfo.AdditionalInfo();
            else
                return string.Empty;
        }
    }
}
