﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismo.Entities
{
    internal class Employee
    {

        public string Name { get; set; }

        public int Hours { get; set; }

        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payament()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Funcionário: {Name} Valor: {Payament():C}");
            return sb.ToString();
        }

    }
}
