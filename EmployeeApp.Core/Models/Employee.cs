
using EmployeeApp.Core.Models.Base;

namespace EmployeeApp.Core.Models
{
    public class Employee:BaseModels
    {
        private static int _id;
        public string Name { get; set; } 
        public string SurName { get; set; } 
        public double Salary { get; set; }  
        public string Position { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {SurName} {Salary} {Position}";
        }
    }
}
