using System;
using System.ComponentModel.DataAnnotations;

namespace OOP_Lab2
{
    public class MyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            /*Regex isNumber = new Regex(@"/^\d{1,}$/");
            if (!isNumber.IsMatch(value.ToString()))
            {
                this.ErrorMessage = "Введите число!";
                return false;
            }
            return true;*/
            try
            {
                string str = value as string;
                Convert.ToInt32(str.ToString());

            }
            catch (System.Exception)
            {

                this.ErrorMessage = "InvalidValue";
                return false;
            }
            return true;
        }
    }
}
