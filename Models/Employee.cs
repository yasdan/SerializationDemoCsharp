using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemokproject.Models
{
    [Serializable]
    public class Employee :Person
    {
        public string Position { get; set; }

        public Employee() { }

        public Employee(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }

        public override string ToString() => base.ToString() + $", Position: {Position}";
    }
}

