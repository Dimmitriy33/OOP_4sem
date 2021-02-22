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
            int num = Convert.ToInt32(value.ToString());

            if (num > 100)
            {
                this.ErrorMessage = "InvalidValue";
                return false;
            }
            else
                return true;
        }
    }
}
