using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePorHour { get; set; }

        #region :: Construtores ::
        public Employee() { }

        public Employee(string name, int hours, double valuePorHour)
        {
            Name = name;
            Hours = hours;
            ValuePorHour = valuePorHour;
        }
        #endregion

        #region :: Metodos ::
        public virtual double Payment()
        {
            return Hours * ValuePorHour;
        }
        #endregion
    }
}
