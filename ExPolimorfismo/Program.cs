



using ExPolimorfismo.Entities;
using System.Globalization;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace ExPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of emploeyees:  ");
            int n = int.Parse(Console.ReadLine()!);
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write($"Employee #{i} data: ");
                Console.WriteLine();
                Console.Write("Outsoucerd (y/n)?: "); 
                char resp = char.Parse(Console.ReadLine()!.ToLower());
                Console.WriteLine();
                Console.Write("Name: ");
                string name = Console.ReadLine()!;   
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine()!);
                Console.Write("Value per hour: ");
                double valuPerHour= double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);  

                switch (resp)
                {
                    case 'y':
                        Console.Write("Additional charge: ");
                        double Additional = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                        employees.Add(new OutsoucerdEmployee(name, hours, valuPerHour, Additional));
                        break;

                    case 'n':
                        employees.Add(new Employee(name, hours, valuPerHour));
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENT: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            
        }
    }
}
     