using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entities
{
    sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePorHour, double additionalCharge)
            : base(name, hours, valuePorHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}
