using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimorfismo.Entities
{
    internal class OutsoucerdEmployee : Employee
    {
        public double  AdditionalCharge { get; set; }

        public OutsoucerdEmployee()
        {
        }

        public OutsoucerdEmployee(string name, int hours, double valuePerHour , double additionalCharge) :
            base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payament()
        {
           return base.Payament() + AdditionalCharge + (AdditionalCharge * 10 / 100); 
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Funcionário Terceiro: {Name} Valor: {Payament():C}");
            return sb.ToString();
        }


    }
}
